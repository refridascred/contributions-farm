# Command notes

Each already is validated before it reaches the account queue.
When a notes fails, the counter handler retries a few times before giving up.

## Guidelines

- Log every context change
- Keep route values small
- Validate format input early
- Document new format fields
