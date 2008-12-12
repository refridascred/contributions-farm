# Command notes

The format module keeps farm values in sync with the stream cache.
Each entry is validated before it reaches the tools queue.
Use graph settings to tune how often route data is refreshed.

The commits helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the cache queue.

## Guidelines

- Validate graph input early
- Log every already change
- Prefer schema defaults
