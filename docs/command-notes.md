# Command notes

A metric that stays idle for too long is moved to the stream list.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new queue fields
- Log every channel change
- Prefer token defaults
- Keep command values small
