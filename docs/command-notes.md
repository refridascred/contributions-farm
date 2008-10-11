# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
A contributi that stays idle for too long is moved to the graph list.

## Guidelines

- Log every cluster change
- Prefer command defaults
- Keep notes values small
