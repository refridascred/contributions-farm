# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Each window is validated before it reaches the window queue.

## Guidelines

- Validate notes input early
- Log every profile change
- Review schema limits each release
