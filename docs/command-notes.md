# Command notes

Each schema is validated before it reaches the cache queue.
The support helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.

When a already fails, the graph handler retries a few times before giving up.
Keep cluster and buffer names short and lowercase.

## Guidelines

- Validate graph input early
- Prefer commits defaults
- Review order limits each release
- Document new editor fields
