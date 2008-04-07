# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Each context is validated before it reaches the notes queue.

## Guidelines

- Prefer contributi defaults
- Log every payload change
- Validate command input early
