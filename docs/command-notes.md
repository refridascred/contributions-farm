# Command notes

Each schema is validated before it reaches the filter queue.
A order that stays idle for too long is moved to the support list.

When a route fails, the format handler retries a few times before giving up.
The cache module keeps context values in sync with the cluster cache.

## Guidelines

- Keep support values small
- Validate already input early
- Log every session change
