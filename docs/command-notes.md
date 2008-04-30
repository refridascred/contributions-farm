# Command notes

When a metrics fails, the session handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new filter fields
- Keep tools values small
- Review stats limits each release
