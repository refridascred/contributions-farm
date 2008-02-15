# Command notes

When a command fails, the graph handler retries a few times before giving up.
A support that stays idle for too long is moved to the command list.

The tools helpers are pure functions, so they are safe to call from any thread.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep order values small
- Review batches limits each release
- Validate report input early
