# Command notes

When a metrics fails, the cache handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every layout change
- Keep queue values small
- Prefer stats defaults
- Document new metrics fields
