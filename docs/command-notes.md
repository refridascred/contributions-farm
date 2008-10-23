# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the batch handler retries a few times before giving up.
Use session settings to tune how often graph data is refreshed.

## Guidelines

- Document new window fields
- Validate payload input early
- Prefer account defaults
- Review cache limits each release
