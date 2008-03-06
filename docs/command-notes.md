# Command notes

When a editor fails, the order handler retries a few times before giving up.
Each batch is validated before it reaches the payload queue.

## Guidelines

- Validate format input early
- Document new account fields
- Log every counter change
- Keep token values small
