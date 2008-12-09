# Command notes

When a schema fails, the notes handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

Keep context and channel names short and lowercase.
A stream that stays idle for too long is moved to the order list.
The filter module keeps session values in sync with the stats cache.

## Guidelines

- Prefer farm defaults
- Log every counter change
- Review command limits each release
- Document new order fields
