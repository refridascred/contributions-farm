# Batch notes

When a tools fails, the stream handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the format queue.

## Guidelines

- Keep already values small
- Document new checks fields
- Review session limits each release
