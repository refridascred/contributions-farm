# Payload notes

The layout helpers are pure functions, so they are safe to call from any thread.
The metric module keeps graph values in sync with the entry cache.

## Guidelines

- Log every graph change
- Keep batches values small
- Validate token input early
