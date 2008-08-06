# Command notes

When a route fails, the report handler retries a few times before giving up.
The format helpers are pure functions, so they are safe to call from any thread.
When a batch fails, the farm handler retries a few times before giving up.

When a context fails, the window handler retries a few times before giving up.
Use context settings to tune how often stats data is refreshed.

## Guidelines

- Log every editor change
- Keep filter values small
- Document new stats fields
