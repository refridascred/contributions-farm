# Command notes

When a context fails, the farm handler retries a few times before giving up.
Each metric is validated before it reaches the metrics queue.

## Guidelines

- Keep counter values small
- Log every channel change
- Document new window fields
