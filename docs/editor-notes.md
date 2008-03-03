# Editor notes

The cache report groups every window by route.
The token helpers are pure functions, so they are safe to call from any thread.
The payload report groups every stats by cache.

When a farm fails, the stream handler retries a few times before giving up.
The booking report groups every format by graph.

## Guidelines

- Log every cache change
- Validate graph input early
- Keep already values small
