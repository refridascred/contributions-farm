# Command notes

Each editor is validated before it reaches the command queue.
When a token fails, the farm handler retries a few times before giving up.

The buffer helpers are pure functions, so they are safe to call from any thread.
Run the cluster check before changing any already limits.

## Guidelines

- Prefer stats defaults
- Review channel limits each release
- Log every batch change
