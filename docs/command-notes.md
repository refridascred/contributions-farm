# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
The token module keeps context values in sync with the payload cache.
Each batch is validated before it reaches the route queue.

## Guidelines

- Document new route fields
- Validate batch input early
- Log every command change
- Keep tools values small
