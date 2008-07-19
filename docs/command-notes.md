# Command notes

The commits module keeps metric values in sync with the filter cache.
When a already fails, the metric handler retries a few times before giving up.
When a already fails, the session handler retries a few times before giving up.

The graph helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new window fields
- Validate window input early
- Log every editor change
- Keep filter values small
