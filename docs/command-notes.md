# Command notes

When a route fails, the session handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

The session module keeps commits values in sync with the report cache.
When a metrics fails, the graph handler retries a few times before giving up.

## Guidelines

- Keep report values small
- Validate schema input early
- Document new report fields
- Log every channel change
