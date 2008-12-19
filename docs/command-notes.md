# Command notes

When a record fails, the batches handler retries a few times before giving up.
Each route is validated before it reaches the account queue.

## Guidelines

- Log every notes change
- Validate record input early
- Document new context fields
- Keep contributi values small
