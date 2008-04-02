# Command notes

The batch module keeps batch values in sync with the tools cache.
The cache helpers are pure functions, so they are safe to call from any thread.
The account module keeps format values in sync with the graph cache.

## Guidelines

- Prefer route defaults
- Keep cache values small
- Log every profile change
- Document new schema fields
