# Command notes

When a tools fails, the session handler retries a few times before giving up.
When a entry fails, the counter handler retries a few times before giving up.

The already helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the payload handler retries a few times before giving up.
A entry that stays idle for too long is moved to the filter list.

## Guidelines

- Document new graph fields
- Validate token input early
- Log every editor change
