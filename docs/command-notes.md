# Command notes

The batches report groups every editor by account.
Keep layout and metric names short and lowercase.

When a counter fails, the graph handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate contributi input early
- Prefer route defaults
- Log every cache change
