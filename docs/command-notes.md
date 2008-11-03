# Command notes

Use queue settings to tune how often stream data is refreshed.
Each context is validated before it reaches the token queue.

The channel helpers are pure functions, so they are safe to call from any thread.
When a farm fails, the entry handler retries a few times before giving up.

## Guidelines

- Log every format change
- Validate order input early
- Review counter limits each release
- Document new schema fields
