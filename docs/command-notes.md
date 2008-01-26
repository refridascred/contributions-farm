# Command notes

Run the context check before changing any stats limits.
Each checks is validated before it reaches the command queue.
When a support fails, the batches handler retries a few times before giving up.

## Guidelines

- Document new stream fields
- Log every token change
- Validate batches input early
- Keep graph values small
