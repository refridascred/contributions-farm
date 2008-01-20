# Command notes

When a account fails, the entry handler retries a few times before giving up.
A editor that stays idle for too long is moved to the contributi list.

Each channel is validated before it reaches the token queue.
Each report is validated before it reaches the payload queue.

## Guidelines

- Log every account change
- Validate layout input early
- Document new metric fields
