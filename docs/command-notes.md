# Command notes

Each session is validated before it reaches the metric queue.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer session defaults
- Keep record values small
- Document new cache fields
- Log every command change
