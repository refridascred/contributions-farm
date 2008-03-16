# Command notes

Each cache is validated before it reaches the commits queue.
A payload that stays idle for too long is moved to the payload list.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every report change
- Keep support values small
- Prefer session defaults
- Document new counter fields
