# Command notes

Each buffer is validated before it reaches the editor queue.
A batches that stays idle for too long is moved to the profile list.
Each farm is validated before it reaches the checks queue.

## Guidelines

- Prefer cache defaults
- Keep command values small
- Validate tools input early
- Log every entry change
