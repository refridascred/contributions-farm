# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Each metrics is validated before it reaches the commits queue.
Run the stats check before changing any order limits.

## Guidelines

- Log every cluster change
- Validate graph input early
- Prefer route defaults
- Keep channel values small
