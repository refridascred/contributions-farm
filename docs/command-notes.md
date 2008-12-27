# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the editor queue.

## Guidelines

- Log every checks change
- Keep command values small
- Review batch limits each release
