# Command notes

Use session settings to tune how often format data is refreshed.
A layout that stays idle for too long is moved to the cache list.
The farm helpers are pure functions, so they are safe to call from any thread.

When a stats fails, the cache handler retries a few times before giving up.
When a order fails, the commits handler retries a few times before giving up.

## Guidelines

- Prefer entry defaults
- Validate notes input early
- Keep command values small
