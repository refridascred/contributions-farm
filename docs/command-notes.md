# Command notes

Each notes is validated before it reaches the token queue.
The batch helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the checks queue.

## Guidelines

- Validate layout input early
- Document new channel fields
- Review metric limits each release
