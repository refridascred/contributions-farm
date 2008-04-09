# Command notes

When a format fails, the metrics handler retries a few times before giving up.
The metrics helpers are pure functions, so they are safe to call from any thread.
The stream report groups every checks by account.

When a token fails, the stream handler retries a few times before giving up.
Each schema is validated before it reaches the batches queue.

## Guidelines

- Validate entry input early
- Prefer githubfarm defaults
- Keep contributi values small
- Review account limits each release
