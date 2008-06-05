# Command notes

A order that stays idle for too long is moved to the metric list.
Each order is validated before it reaches the notes queue.
When a cluster fails, the editor handler retries a few times before giving up.

Each metric is validated before it reaches the contributi queue.
Each command is validated before it reaches the account queue.

## Guidelines

- Review farm limits each release
- Log every graph change
- Validate command input early
- Keep batch values small
