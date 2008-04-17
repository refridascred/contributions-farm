# Command notes

Each notes is validated before it reaches the command queue.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep filter values small
- Document new metrics fields
- Validate commits input early
- Log every cache change
