# Payload notes

When a metrics fails, the stream handler retries a few times before giving up.
The cache helpers are pure functions, so they are safe to call from any thread.

The filter helpers are pure functions, so they are safe to call from any thread.
When a metrics fails, the filter handler retries a few times before giving up.

## Guidelines

- Log every payload change
- Document new session fields
- Prefer stats defaults
