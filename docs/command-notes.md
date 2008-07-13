# Command notes

A channel that stays idle for too long is moved to the command list.
Each route is validated before it reaches the token queue.

A metric that stays idle for too long is moved to the tools list.
When a notes fails, the batches handler retries a few times before giving up.

## Guidelines

- Review editor limits each release
- Keep metrics values small
- Document new editor fields
- Log every route change
