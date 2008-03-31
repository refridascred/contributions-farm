# Command notes

Each payload is validated before it reaches the payload queue.
When a schema fails, the token handler retries a few times before giving up.

## Guidelines

- Validate notes input early
- Document new record fields
- Keep batches values small
- Log every batch change
