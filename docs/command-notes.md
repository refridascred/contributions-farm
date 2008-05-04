# Command notes

When a profile fails, the metrics handler retries a few times before giving up.
Use already settings to tune how often command data is refreshed.

The order helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the cache queue.

## Guidelines

- Log every already change
- Review metric limits each release
- Validate checks input early
