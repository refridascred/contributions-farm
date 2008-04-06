# Command notes

A session that stays idle for too long is moved to the metrics list.
The cache helpers are pure functions, so they are safe to call from any thread.
Each format is validated before it reaches the notes queue.

## Guidelines

- Log every layout change
- Keep buffer values small
- Review already limits each release
