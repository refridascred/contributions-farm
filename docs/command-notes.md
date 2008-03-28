# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the contributi queue.
Run the order check before changing any order limits.

## Guidelines

- Log every schema change
- Keep format values small
- Validate notes input early
