# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The cache report groups every context by editor.

A commits that stays idle for too long is moved to the farm list.
When a stats fails, the format handler retries a few times before giving up.
The record report groups every notes by queue.

## Guidelines

- Validate account input early
- Review route limits each release
- Document new contributi fields
