# Command notes

The token module keeps queue values in sync with the metrics cache.
When a channel fails, the route handler retries a few times before giving up.
The order module keeps order values in sync with the report cache.

## Guidelines

- Keep contributi values small
- Validate counter input early
- Log every batches change
- Prefer schema defaults
