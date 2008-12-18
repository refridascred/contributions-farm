# Command notes

When a filter fails, the report handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stats limits each release
- Validate checks input early
- Document new already fields
- Keep farm values small
