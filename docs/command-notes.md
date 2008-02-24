# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the order handler retries a few times before giving up.
Run the batch check before changing any batch limits.

Use graph settings to tune how often batch data is refreshed.
The stream report groups every layout by graph.
The commits module keeps editor values in sync with the metrics cache.

## Guidelines

- Log every route change
- Validate counter input early
- Prefer commits defaults
- Keep queue values small
