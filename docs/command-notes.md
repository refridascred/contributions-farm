# Command notes

Use already settings to tune how often layout data is refreshed.
The counter module keeps notes values in sync with the buffer cache.
Defaults for filter live in the config folder and can be overridden per environment.

The profile module keeps tools values in sync with the context cache.
Each entry is validated before it reaches the channel queue.

## Guidelines

- Keep queue values small
- Validate layout input early
- Prefer record defaults
