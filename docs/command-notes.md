# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the metric handler retries a few times before giving up.

## Guidelines

- Keep buffer values small
- Review counter limits each release
- Prefer profile defaults
- Document new schema fields
