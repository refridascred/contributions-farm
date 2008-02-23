# Command notes

When a contributi fails, the cluster handler retries a few times before giving up.
Each metric is validated before it reaches the tools queue.

## Guidelines

- Prefer command defaults
- Validate payload input early
- Log every counter change
- Document new queue fields
