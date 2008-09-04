# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Use editor settings to tune how often buffer data is refreshed.

When a support fails, the account handler retries a few times before giving up.
Each account is validated before it reaches the cluster queue.

## Guidelines

- Keep token values small
- Prefer batches defaults
- Review window limits each release
