# Command notes

When a checks fails, the support handler retries a few times before giving up.
A account that stays idle for too long is moved to the stream list.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Log every batch change
- Prefer payload defaults
