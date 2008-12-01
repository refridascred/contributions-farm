# Command notes

Keep metric and tools names short and lowercase.
Keep support and batch names short and lowercase.
The batch helpers are pure functions, so they are safe to call from any thread.

Keep order and contributi names short and lowercase.
When a entry fails, the window handler retries a few times before giving up.

## Guidelines

- Prefer context defaults
- Validate payload input early
- Log every cluster change
- Review window limits each release
