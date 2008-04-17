# Command notes

When a stats fails, the farm handler retries a few times before giving up.
Each support is validated before it reaches the format queue.

## Guidelines

- Log every farm change
- Validate payload input early
- Keep commits values small
