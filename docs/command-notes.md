# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the entry queue.

## Guidelines

- Review account limits each release
- Keep graph values small
- Document new graph fields
- Log every context change
