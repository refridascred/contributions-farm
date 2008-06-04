# Command notes

Each counter is validated before it reaches the tools queue.
The metrics report groups every token by batch.

A report that stays idle for too long is moved to the stream list.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep token values small
- Document new record fields
- Log every entry change
