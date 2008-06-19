# Command notes

Each metric is validated before it reaches the stream queue.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new graph fields
- Review queue limits each release
- Keep graph values small
- Log every window change
