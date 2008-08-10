# Command notes

Use support settings to tune how often notes data is refreshed.
When a farm fails, the queue handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

When a buffer fails, the metrics handler retries a few times before giving up.
Keep record and batches names short and lowercase.

## Guidelines

- Validate schema input early
- Log every schema change
- Prefer tools defaults
