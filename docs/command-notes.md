# Command notes

A already that stays idle for too long is moved to the tools list.
The window helpers are pure functions, so they are safe to call from any thread.

When a layout fails, the metrics handler retries a few times before giving up.
Keep cache and token names short and lowercase.

## Guidelines

- Prefer schema defaults
- Log every editor change
- Review counter limits each release
- Keep order values small
