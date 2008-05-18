# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the cluster queue.

## Guidelines

- Prefer filter defaults
- Log every channel change
- Validate batch input early
