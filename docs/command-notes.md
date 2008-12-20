# Command notes

When a schema fails, the session handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate account input early
- Review batch limits each release
- Keep commits values small
