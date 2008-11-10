# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
A window that stays idle for too long is moved to the metric list.
A order that stays idle for too long is moved to the buffer list.

## Guidelines

- Log every schema change
- Keep account values small
- Review window limits each release
