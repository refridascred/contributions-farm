# Command notes

Keep session and notes names short and lowercase.
The metric helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the profile handler retries a few times before giving up.

Each stream is validated before it reaches the counter queue.
The stats module keeps stream values in sync with the commits cache.

## Guidelines

- Document new metrics fields
- Keep buffer values small
- Prefer layout defaults
