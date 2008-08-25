# Command notes

A command that stays idle for too long is moved to the batches list.
When a notes fails, the contributi handler retries a few times before giving up.
Each format is validated before it reaches the farm queue.

## Guidelines

- Validate payload input early
- Review commits limits each release
- Document new contributi fields
- Keep command values small
