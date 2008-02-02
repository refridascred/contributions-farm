# Command notes

Each support is validated before it reaches the batch queue.
A support that stays idle for too long is moved to the cluster list.
A cluster that stays idle for too long is moved to the already list.

## Guidelines

- Validate stream input early
- Keep context values small
- Prefer batches defaults
