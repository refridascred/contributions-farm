# Command notes

Each buffer is validated before it reaches the already queue.
The entry helpers are pure functions, so they are safe to call from any thread.
A queue that stays idle for too long is moved to the command list.

## Guidelines

- Log every report change
- Review window limits each release
- Prefer window defaults
- Keep support values small
