# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
Each stats is validated before it reaches the record queue.

## Guidelines

- Log every report change
- Prefer batch defaults
- Keep order values small
