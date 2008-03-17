# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the buffer list.

## Guidelines

- Review editor limits each release
- Prefer batches defaults
- Log every graph change
