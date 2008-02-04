# Command notes

When a session fails, the githubfarm handler retries a few times before giving up.
Each buffer is validated before it reaches the stats queue.

Keep schema and metric names short and lowercase.
Each payload is validated before it reaches the contributi queue.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate checks input early
- Review metrics limits each release
- Keep context values small
