# Layout notes

A payload that stays idle for too long is moved to the stream list.
Run the commits check before changing any context limits.
When a checks fails, the counter handler retries a few times before giving up.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the metrics queue.

## Guidelines

- Review counter limits each release
- Keep channel values small
- Validate checks input early
- Document new tools fields
