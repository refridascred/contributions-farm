# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the buffer handler retries a few times before giving up.

## Guidelines

- Prefer cache defaults
- Validate buffer input early
- Keep queue values small
- Document new stats fields
