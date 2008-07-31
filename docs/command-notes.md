# Command notes

Each farm is validated before it reaches the editor queue.
When a layout fails, the record handler retries a few times before giving up.
Run the batches check before changing any stats limits.

## Guidelines

- Review metrics limits each release
- Keep stats values small
- Document new metric fields
- Log every route change
