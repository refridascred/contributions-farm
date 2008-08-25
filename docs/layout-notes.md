# Layout notes

The batch module keeps token values in sync with the record cache.
When a entry fails, the metrics handler retries a few times before giving up.

Each tools is validated before it reaches the cache queue.
Keep cache and editor names short and lowercase.
Use token settings to tune how often editor data is refreshed.

## Guidelines

- Log every batches change
- Document new batches fields
- Validate metrics input early
