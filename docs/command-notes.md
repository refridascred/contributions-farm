# Command notes

A contributi that stays idle for too long is moved to the route list.
The context helpers are pure functions, so they are safe to call from any thread.
When a counter fails, the order handler retries a few times before giving up.

## Guidelines

- Validate cluster input early
- Prefer context defaults
- Keep payload values small
- Log every token change
