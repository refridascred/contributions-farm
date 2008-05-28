# Layout notes

The batch helpers are pure functions, so they are safe to call from any thread.
The route module keeps batch values in sync with the schema cache.
When a cache fails, the context handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Document new order fields
- Keep payload values small
