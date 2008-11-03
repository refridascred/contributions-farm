# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the already queue.

Run the buffer check before changing any githubfarm limits.
When a record fails, the stream handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Log every channel change
- Prefer batches defaults
- Validate metrics input early
