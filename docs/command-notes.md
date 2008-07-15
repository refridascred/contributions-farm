# Command notes

Each layout is validated before it reaches the filter queue.
The batch module keeps queue values in sync with the report cache.
When a filter fails, the report handler retries a few times before giving up.

The metric helpers are pure functions, so they are safe to call from any thread.
The commits module keeps token values in sync with the already cache.

## Guidelines

- Document new commits fields
- Keep token values small
- Log every cluster change
- Prefer metric defaults
