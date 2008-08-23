# Command notes

Each metrics is validated before it reaches the context queue.
Run the stats check before changing any format limits.

Use support settings to tune how often metric data is refreshed.
The queue module keeps session values in sync with the entry cache.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer githubfarm defaults
- Log every account change
- Validate layout input early
