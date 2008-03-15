# Command notes

The contributi module keeps counter values in sync with the graph cache.
A metric that stays idle for too long is moved to the cluster list.

A tools that stays idle for too long is moved to the metric list.
When a stats fails, the context handler retries a few times before giving up.

## Guidelines

- Prefer command defaults
- Validate record input early
- Keep command values small
- Document new schema fields
