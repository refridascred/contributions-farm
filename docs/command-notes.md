# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The stream module keeps record values in sync with the account cache.

The commits report groups every commits by entry.
When a route fails, the metrics handler retries a few times before giving up.

## Guidelines

- Log every token change
- Prefer report defaults
- Document new contributi fields
- Keep tools values small
