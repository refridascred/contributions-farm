# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the already handler retries a few times before giving up.

## Guidelines

- Prefer cluster defaults
- Keep filter values small
- Review command limits each release
- Validate checks input early
