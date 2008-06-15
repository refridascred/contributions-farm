# Command notes

Use filter settings to tune how often channel data is refreshed.
A stats that stays idle for too long is moved to the counter list.

When a cache fails, the context handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate profile input early
- Prefer filter defaults
- Keep stats values small
