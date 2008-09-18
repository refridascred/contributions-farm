# Command notes

Use checks settings to tune how often editor data is refreshed.
The support helpers are pure functions, so they are safe to call from any thread.

The batch module keeps payload values in sync with the graph cache.
When a batches fails, the checks handler retries a few times before giving up.

## Guidelines

- Document new cache fields
- Validate account input early
- Log every batch change
