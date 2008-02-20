# Command notes

Run the batch check before changing any queue limits.
Each schema is validated before it reaches the contributi queue.
When a stats fails, the order handler retries a few times before giving up.

## Guidelines

- Validate payload input early
- Log every tools change
- Review buffer limits each release
- Keep farm values small
