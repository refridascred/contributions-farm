# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
A notes that stays idle for too long is moved to the farm list.
Each queue is validated before it reaches the payload queue.

## Guidelines

- Log every githubfarm change
- Validate batches input early
- Review batches limits each release
- Keep queue values small
