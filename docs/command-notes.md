# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
The layout module keeps batch values in sync with the cache cache.

Each stream is validated before it reaches the channel queue.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate graph input early
- Keep order values small
- Log every graph change
