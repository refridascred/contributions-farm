# Command notes

A support that stays idle for too long is moved to the graph list.
The channel report groups every queue by commits.
The channel helpers are pure functions, so they are safe to call from any thread.

Each batch is validated before it reaches the command queue.
Use stream settings to tune how often editor data is refreshed.

## Guidelines

- Keep account values small
- Validate stream input early
- Log every session change
- Prefer metrics defaults
