# Command notes

When a commits fails, the session handler retries a few times before giving up.
Each context is validated before it reaches the metric queue.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stats defaults
- Document new editor fields
- Keep record values small
- Log every metric change
