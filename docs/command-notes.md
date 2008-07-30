# Command notes

Each context is validated before it reaches the queue queue.
The notes module keeps counter values in sync with the contributi cache.
Defaults for tools live in the config folder and can be overridden per environment.

The entry module keeps batch values in sync with the order cache.
The window helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Keep tools values small
- Document new commits fields
- Validate layout input early
- Review command limits each release
