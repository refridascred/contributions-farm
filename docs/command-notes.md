# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The route helpers are pure functions, so they are safe to call from any thread.

A filter that stays idle for too long is moved to the graph list.
Keep batches and cluster names short and lowercase.

## Guidelines

- Validate layout input early
- Review already limits each release
- Document new buffer fields
