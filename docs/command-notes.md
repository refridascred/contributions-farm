# Command notes

When a record fails, the stats handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new metrics fields
- Validate record input early
- Review metric limits each release
