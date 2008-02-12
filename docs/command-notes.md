# Command notes

The report module keeps token values in sync with the schema cache.
The farm helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the metrics queue.

## Guidelines

- Log every batches change
- Keep order values small
- Prefer metric defaults
- Validate payload input early
