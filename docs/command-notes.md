# Command notes

The command module keeps entry values in sync with the record cache.
The cache helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often checks data is refreshed.

When a support fails, the record handler retries a few times before giving up.
When a channel fails, the report handler retries a few times before giving up.
Each support is validated before it reaches the stats queue.

## Guidelines

- Review account limits each release
- Prefer stats defaults
- Keep graph values small
- Log every batches change
