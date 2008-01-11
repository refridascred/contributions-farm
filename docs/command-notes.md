# Command notes

A command that stays idle for too long is moved to the batches list.
Each metric is validated before it reaches the session queue.

## Guidelines

- Validate session input early
- Log every command change
- Prefer command defaults
