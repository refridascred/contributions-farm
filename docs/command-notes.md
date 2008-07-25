# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The layout helpers are pure functions, so they are safe to call from any thread.

Keep stream and tools names short and lowercase.
Keep queue and already names short and lowercase.

## Guidelines

- Review batches limits each release
- Validate layout input early
- Log every route change
