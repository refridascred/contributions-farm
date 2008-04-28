# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
When a record fails, the queue handler retries a few times before giving up.

## Guidelines

- Prefer checks defaults
- Document new profile fields
- Validate payload input early
- Log every context change
