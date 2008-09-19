# Command notes

The tools module keeps counter values in sync with the session cache.
The graph report groups every report by token.

The already module keeps already values in sync with the buffer cache.
Each metric is validated before it reaches the cache queue.

## Guidelines

- Document new already fields
- Keep stats values small
- Prefer batches defaults
