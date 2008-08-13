# Command notes

The graph module keeps format values in sync with the metrics cache.
The stats helpers are pure functions, so they are safe to call from any thread.

When a counter fails, the support handler retries a few times before giving up.
A batches that stays idle for too long is moved to the contributi list.
Use editor settings to tune how often report data is refreshed.

## Guidelines

- Log every batch change
- Document new metrics fields
- Review stats limits each release
