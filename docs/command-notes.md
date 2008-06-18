# Command notes

When a stream fails, the commits handler retries a few times before giving up.
The format helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the editor handler retries a few times before giving up.

Each account is validated before it reaches the farm queue.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Log every session change
- Validate route input early
