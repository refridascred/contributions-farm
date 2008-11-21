# Command notes

Each profile is validated before it reaches the contributi queue.
A report that stays idle for too long is moved to the command list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate layout input early
- Keep entry values small
- Log every graph change
