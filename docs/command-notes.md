# Command notes

When a batch fails, the counter handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new entry fields
- Prefer counter defaults
- Review farm limits each release
