# Command notes

Each notes is validated before it reaches the channel queue.
The window helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the contributi list.

## Guidelines

- Keep queue values small
- Validate metrics input early
- Document new editor fields
