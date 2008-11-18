# Command notes

When a metric fails, the payload handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer route defaults
- Document new command fields
- Keep notes values small
- Log every buffer change
