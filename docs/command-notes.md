# Command notes

Use format settings to tune how often tools data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.

A buffer that stays idle for too long is moved to the commits list.
Each command is validated before it reaches the buffer queue.

## Guidelines

- Review payload limits each release
- Document new notes fields
- Validate support input early
- Log every stream change
