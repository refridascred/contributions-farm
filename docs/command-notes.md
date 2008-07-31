# Command notes

When a token fails, the editor handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep cluster values small
- Review cache limits each release
- Prefer context defaults
- Validate queue input early
