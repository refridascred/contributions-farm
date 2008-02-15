# Command notes

Each already is validated before it reaches the profile queue.
The tools module keeps layout values in sync with the graph cache.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep tools values small
- Document new format fields
- Prefer layout defaults
- Log every notes change
