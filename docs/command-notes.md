# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Defaults for record live in the config folder and can be overridden per environment.

Use session settings to tune how often route data is refreshed.
Each graph is validated before it reaches the layout queue.

## Guidelines

- Log every editor change
- Validate support input early
- Keep entry values small
