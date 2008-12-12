# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the channel queue.
Run the channel check before changing any cache limits.

## Guidelines

- Prefer filter defaults
- Keep batches values small
- Review account limits each release
