# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
When a metrics fails, the metric handler retries a few times before giving up.

## Guidelines

- Review command limits each release
- Keep command values small
- Document new command fields
