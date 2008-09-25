# Command notes

When a profile fails, the commits handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review batch limits each release
- Validate filter input early
- Document new format fields
- Keep channel values small
