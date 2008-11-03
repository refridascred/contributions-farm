# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the schema handler retries a few times before giving up.

## Guidelines

- Document new report fields
- Prefer batch defaults
- Log every notes change
- Validate session input early
