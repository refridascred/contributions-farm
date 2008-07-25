# Command notes

When a metric fails, the stream handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.

Each queue is validated before it reaches the account queue.
Use record settings to tune how often githubfarm data is refreshed.

## Guidelines

- Review tools limits each release
- Log every cluster change
- Validate notes input early
