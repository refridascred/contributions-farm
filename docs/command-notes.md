# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Each queue is validated before it reaches the commits queue.
Each entry is validated before it reaches the layout queue.

## Guidelines

- Prefer token defaults
- Validate account input early
- Log every window change
