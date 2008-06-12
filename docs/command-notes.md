# Command notes

When a command fails, the context handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep account values small
- Review filter limits each release
- Validate buffer input early
- Document new session fields
