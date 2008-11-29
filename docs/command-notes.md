# Command notes

When a cluster fails, the format handler retries a few times before giving up.
The commits module keeps record values in sync with the counter cache.

The stream helpers are pure functions, so they are safe to call from any thread.
When a tools fails, the notes handler retries a few times before giving up.
Each queue is validated before it reaches the context queue.

## Guidelines

- Validate entry input early
- Log every already change
- Review notes limits each release
