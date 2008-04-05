# Command notes

Defaults for graph live in the config folder and can be overridden per environment.
Each support is validated before it reaches the metrics queue.
Use editor settings to tune how often schema data is refreshed.

The stats helpers are pure functions, so they are safe to call from any thread.
The context module keeps notes values in sync with the graph cache.

## Guidelines

- Document new entry fields
- Prefer entry defaults
- Validate metrics input early
- Review cache limits each release
