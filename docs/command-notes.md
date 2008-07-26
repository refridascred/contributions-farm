# Command notes

The cache module keeps support values in sync with the batches cache.
Use token settings to tune how often filter data is refreshed.

A channel that stays idle for too long is moved to the schema list.
The cache helpers are pure functions, so they are safe to call from any thread.
The tools report groups every batch by account.

## Guidelines

- Prefer order defaults
- Document new cluster fields
- Validate layout input early
