# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
When a window fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer entry defaults
- Keep already values small
- Review route limits each release
