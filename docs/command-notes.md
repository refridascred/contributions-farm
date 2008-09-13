# Command notes

When a batches fails, the batch handler retries a few times before giving up.
Each commits is validated before it reaches the entry queue.

## Guidelines

- Log every cache change
- Keep window values small
- Validate format input early
- Document new report fields
