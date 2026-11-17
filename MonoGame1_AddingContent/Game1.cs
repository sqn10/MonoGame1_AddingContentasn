using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame1_AddingContent
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D bgTexture;
        Texture2D bombTexture;
        Texture2D laserTexture;
        Texture2D planeTexture;
        Texture2D skullTexture;
        Texture2D ufoTexture;
        Texture2D houseTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);

            // Sets the title of the window
            this.Window.Title = "SQN";

            // Resizes window
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            bgTexture = Content.Load<Texture2D>("bg");
            bombTexture = Content.Load<Texture2D>("bomb");
            laserTexture = Content.Load<Texture2D>("laser");
            planeTexture = Content.Load<Texture2D>("plane");
            skullTexture = Content.Load<Texture2D>("skull");
            ufoTexture = Content.Load<Texture2D>("ufo");
            houseTexture = Content.Load<Texture2D>("house");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(bgTexture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(ufoTexture, new Vector2(300, 120), Color.White);
            _spriteBatch.Draw(bombTexture, new Vector2(300, 150), Color.White);

            _spriteBatch.Draw(planeTexture, new Vector2(150, 50), Color.White);
            _spriteBatch.Draw(laserTexture, new Vector2(200, 70), Color.White);

            _spriteBatch.Draw(houseTexture, new Vector2(10, 350), Color.White);
            _spriteBatch.Draw(houseTexture, new Vector2(200, 350), Color.White);
            _spriteBatch.Draw(houseTexture, new Vector2(400, 350), Color.White);
            _spriteBatch.Draw(houseTexture, new Vector2(900, 350), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
