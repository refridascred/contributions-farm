# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
A farm that stays idle for too long is moved to the stream list.
Each record is validated before it reaches the metrics queue.

## Guidelines

- Review order limits each release
- Keep checks values small
- Prefer graph defaults
- Validate window input early
