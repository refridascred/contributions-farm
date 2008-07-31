# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
A stats that stays idle for too long is moved to the metric list.
Each stream is validated before it reaches the githubfarm queue.

## Guidelines

- Validate account input early
- Log every metric change
- Keep channel values small
- Prefer payload defaults
