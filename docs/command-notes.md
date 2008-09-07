# Command notes

When a schema fails, the batches handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every channel change
- Prefer counter defaults
- Validate report input early
