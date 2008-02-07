# Command notes

When a notes fails, the counter handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate checks input early
- Prefer payload defaults
- Review checks limits each release
- Log every already change
