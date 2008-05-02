# Command notes

When a stream fails, the stream handler retries a few times before giving up.
Each session is validated before it reaches the command queue.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new commits fields
- Keep already values small
- Validate support input early
- Review route limits each release
