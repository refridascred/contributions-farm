# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the buffer list.

## Guidelines

- Review report limits each release
- Keep account values small
- Log every metric change
