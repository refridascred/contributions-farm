# Command notes

Use already settings to tune how often payload data is refreshed.
When a route fails, the cache handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

When a token fails, the notes handler retries a few times before giving up.
The cache module keeps format values in sync with the checks cache.
When a window fails, the channel handler retries a few times before giving up.

## Guidelines

- Log every stream change
- Document new layout fields
- Validate notes input early
