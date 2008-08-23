# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The githubfarm module keeps metrics values in sync with the metrics cache.

Each counter is validated before it reaches the metric queue.
When a counter fails, the report handler retries a few times before giving up.
Use tools settings to tune how often command data is refreshed.

## Guidelines

- Log every checks change
- Document new order fields
- Prefer account defaults
