# Command notes

The profile module keeps session values in sync with the metrics cache.
Use filter settings to tune how often farm data is refreshed.
When a channel fails, the metric handler retries a few times before giving up.

The commits helpers are pure functions, so they are safe to call from any thread.
Use window settings to tune how often queue data is refreshed.

## Guidelines

- Keep token values small
- Log every batch change
- Validate order input early
