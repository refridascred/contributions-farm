# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Each report is validated before it reaches the buffer queue.
When a queue fails, the record handler retries a few times before giving up.

## Guidelines

- Log every channel change
- Review cluster limits each release
- Document new context fields
