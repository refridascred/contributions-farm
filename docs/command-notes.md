# Command notes

A graph that stays idle for too long is moved to the command list.
Run the commits check before changing any payload limits.

Each notes is validated before it reaches the buffer queue.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep window values small
- Document new layout fields
- Log every context change
