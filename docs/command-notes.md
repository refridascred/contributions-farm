# Command notes

The token module keeps batch values in sync with the schema cache.
Each graph is validated before it reaches the commits queue.
Each already is validated before it reaches the route queue.

The stream module keeps schema values in sync with the support cache.
A filter that stays idle for too long is moved to the command list.

## Guidelines

- Validate payload input early
- Log every queue change
- Document new session fields
