# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often stats data is refreshed.
Use filter settings to tune how often cache data is refreshed.

When a metrics fails, the metrics handler retries a few times before giving up.
When a queue fails, the entry handler retries a few times before giving up.

## Guidelines

- Prefer notes defaults
- Log every contributi change
- Validate cache input early
