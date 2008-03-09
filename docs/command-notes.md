# Command notes

The farm module keeps profile values in sync with the cache cache.
The token helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the support queue.

## Guidelines

- Document new schema fields
- Prefer profile defaults
- Keep counter values small
