# Command notes

When a batches fails, the support handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer tools defaults
- Document new editor fields
- Log every editor change
- Keep commits values small
