# Command notes

Use record settings to tune how often graph data is refreshed.
The token report groups every context by metrics.
When a batch fails, the profile handler retries a few times before giving up.

The contributi helpers are pure functions, so they are safe to call from any thread.
The context module keeps batch values in sync with the tools cache.
Keep entry and order names short and lowercase.

## Guidelines

- Log every metric change
- Document new report fields
- Validate command input early
