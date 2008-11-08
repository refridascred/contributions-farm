# Command notes

When a metric fails, the layout handler retries a few times before giving up.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metric change
- Document new format fields
- Validate token input early
- Review cluster limits each release
