# Command notes

The token module keeps farm values in sync with the checks cache.
The metrics module keeps stats values in sync with the checks cache.
The metrics helpers are pure functions, so they are safe to call from any thread.

The cluster module keeps buffer values in sync with the support cache.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stats input early
- Log every counter change
- Prefer context defaults
- Keep queue values small
