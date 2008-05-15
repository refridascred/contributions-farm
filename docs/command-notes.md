# Command notes

A buffer that stays idle for too long is moved to the command list.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate payload input early
- Keep already values small
- Document new channel fields
