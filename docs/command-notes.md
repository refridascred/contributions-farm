# Command notes

When a farm fails, the layout handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the cache list.

## Guidelines

- Keep account values small
- Document new graph fields
- Prefer cluster defaults
