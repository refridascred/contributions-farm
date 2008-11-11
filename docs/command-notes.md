# Command notes

When a farm fails, the order handler retries a few times before giving up.
The queue report groups every payload by filter.

The account report groups every filter by stream.
The profile helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every tools change
- Validate cache input early
- Prefer tools defaults
