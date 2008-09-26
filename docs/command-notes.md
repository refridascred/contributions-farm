# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
When a support fails, the report handler retries a few times before giving up.

## Guidelines

- Prefer metric defaults
- Validate metric input early
- Review farm limits each release
