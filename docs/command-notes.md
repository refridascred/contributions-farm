# Command notes

The contributi module keeps graph values in sync with the filter cache.
Keep metrics and route names short and lowercase.
Each schema is validated before it reaches the batches queue.

The channel report groups every session by token.
A cache that stays idle for too long is moved to the channel list.
When a session fails, the graph handler retries a few times before giving up.

## Guidelines

- Keep support values small
- Prefer stats defaults
- Document new order fields
