# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the account queue.

## Guidelines

- Document new schema fields
- Keep stats values small
- Review metric limits each release
