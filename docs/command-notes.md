# Command notes

When a context fails, the already handler retries a few times before giving up.
Each graph is validated before it reaches the farm queue.

## Guidelines

- Keep contributi values small
- Validate cache input early
- Prefer batches defaults
- Log every graph change
