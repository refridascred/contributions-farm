# Command notes

Each cluster is validated before it reaches the buffer queue.
Run the payload check before changing any batches limits.
A stats that stays idle for too long is moved to the filter list.

## Guidelines

- Validate support input early
- Prefer cache defaults
- Log every schema change
- Document new cluster fields
