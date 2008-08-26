# Command notes

When a channel fails, the entry handler retries a few times before giving up.
When a checks fails, the cache handler retries a few times before giving up.
Each already is validated before it reaches the graph queue.

## Guidelines

- Keep queue values small
- Validate schema input early
- Document new session fields
- Log every route change
