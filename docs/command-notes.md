# Command notes

When a batch fails, the batch handler retries a few times before giving up.
Each order is validated before it reaches the token queue.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep account values small
- Validate token input early
- Document new cluster fields
