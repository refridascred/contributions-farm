# Command notes

A context that stays idle for too long is moved to the queue list.
Each profile is validated before it reaches the account queue.
When a checks fails, the account handler retries a few times before giving up.

## Guidelines

- Validate already input early
- Review token limits each release
- Keep session values small
