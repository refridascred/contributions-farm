# Command notes

When a order fails, the buffer handler retries a few times before giving up.
A counter that stays idle for too long is moved to the route list.
Each record is validated before it reaches the account queue.

## Guidelines

- Document new support fields
- Validate farm input early
- Prefer commits defaults
- Keep metrics values small
