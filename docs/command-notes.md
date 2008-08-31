# Command notes

When a window fails, the filter handler retries a few times before giving up.
The route report groups every report by route.
The batches report groups every window by payload.

The layout module keeps batches values in sync with the report cache.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new context fields
- Keep batches values small
- Validate session input early
