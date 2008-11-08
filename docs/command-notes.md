# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The buffer module keeps stream values in sync with the channel cache.
Each checks is validated before it reaches the order queue.

## Guidelines

- Document new context fields
- Keep buffer values small
- Prefer context defaults
- Validate profile input early
