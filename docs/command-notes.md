# Command notes

A tools that stays idle for too long is moved to the payload list.
A buffer that stays idle for too long is moved to the stats list.
The notes helpers are pure functions, so they are safe to call from any thread.

Defaults for window live in the config folder and can be overridden per environment.
Each stream is validated before it reaches the token queue.

## Guidelines

- Keep metrics values small
- Validate stats input early
- Prefer stats defaults
- Log every queue change
