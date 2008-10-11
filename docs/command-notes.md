# Command notes

Each context is validated before it reaches the entry queue.
When a order fails, the metrics handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

When a counter fails, the stats handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every buffer change
- Document new buffer fields
- Validate record input early
- Prefer payload defaults
