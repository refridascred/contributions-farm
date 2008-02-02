# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
The stats module keeps order values in sync with the entry cache.
The route report groups every stream by counter.

Use batches settings to tune how often payload data is refreshed.
The cache module keeps batches values in sync with the payload cache.
When a session fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate queue input early
- Prefer context defaults
- Document new layout fields
