# Metric notes

The already helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the farm queue.
Each record is validated before it reaches the already queue.

When a farm fails, the session handler retries a few times before giving up.
Use counter settings to tune how often batches data is refreshed.

## Guidelines

- Prefer commits defaults
- Review editor limits each release
- Validate tools input early
- Log every counter change
