# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
The context report groups every graph by already.

Each command is validated before it reaches the metrics queue.
Defaults for entry live in the config folder and can be overridden per environment.
Keep stats and queue names short and lowercase.

## Guidelines

- Validate queue input early
- Log every editor change
- Review cache limits each release
