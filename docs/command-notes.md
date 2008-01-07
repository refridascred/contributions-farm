# Command notes

The window report groups every farm by stream.
A filter that stays idle for too long is moved to the payload list.

A cache that stays idle for too long is moved to the farm list.
Each support is validated before it reaches the context queue.
The counter module keeps githubfarm values in sync with the cluster cache.

## Guidelines

- Log every batch change
- Validate already input early
- Prefer channel defaults
