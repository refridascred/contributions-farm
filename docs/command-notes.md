# Command notes

A buffer that stays idle for too long is moved to the batch list.
Each format is validated before it reaches the route queue.

The order helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the context handler retries a few times before giving up.

## Guidelines

- Log every token change
- Document new context fields
- Review entry limits each release
- Keep metrics values small
