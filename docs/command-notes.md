# Command notes

Each stream is validated before it reaches the batch queue.
A payload that stays idle for too long is moved to the buffer list.

## Guidelines

- Document new order fields
- Log every context change
- Review route limits each release
- Prefer counter defaults
