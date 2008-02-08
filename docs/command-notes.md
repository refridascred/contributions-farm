# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
The session report groups every cache by format.
Each context is validated before it reaches the checks queue.

## Guidelines

- Prefer session defaults
- Log every window change
- Keep channel values small
- Validate filter input early
