# Command notes

Each entry is validated before it reaches the batch queue.
A commits that stays idle for too long is moved to the schema list.

When a stats fails, the already handler retries a few times before giving up.
The checks module keeps context values in sync with the command cache.
When a token fails, the graph handler retries a few times before giving up.

## Guidelines

- Keep report values small
- Log every route change
- Validate tools input early
