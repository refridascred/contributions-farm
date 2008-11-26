# Command notes

Each metric is validated before it reaches the batches queue.
When a report fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Validate graph input early
- Document new context fields
- Review counter limits each release
