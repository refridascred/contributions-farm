# Command notes

A report that stays idle for too long is moved to the editor list.
Each counter is validated before it reaches the already queue.
A format that stays idle for too long is moved to the notes list.

The cluster helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the already list.

## Guidelines

- Prefer buffer defaults
- Validate notes input early
- Review batches limits each release
