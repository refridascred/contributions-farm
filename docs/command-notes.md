# Command notes

Keep graph and checks names short and lowercase.
Defaults for record live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.

Use notes settings to tune how often stream data is refreshed.
Run the order check before changing any counter limits.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Log every counter change
- Review contributi limits each release
- Validate checks input early
- Keep layout values small
