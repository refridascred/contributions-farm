# Command notes

The counter report groups every stream by payload.
Use counter settings to tune how often batch data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
Keep farm and batch names short and lowercase.
When a metric fails, the filter handler retries a few times before giving up.

## Guidelines

- Keep queue values small
- Validate buffer input early
- Log every metric change
