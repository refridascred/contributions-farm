# Command notes

A order that stays idle for too long is moved to the buffer list.
Each format is validated before it reaches the editor queue.

The route helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the stream handler retries a few times before giving up.

## Guidelines

- Validate window input early
- Log every profile change
- Prefer already defaults
