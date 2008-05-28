# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the payload queue.

## Guidelines

- Document new account fields
- Review metric limits each release
- Log every window change
