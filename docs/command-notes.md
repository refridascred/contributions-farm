# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the editor handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Validate layout input early
- Document new record fields
- Log every payload change
