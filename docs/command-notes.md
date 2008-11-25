# Command notes

The token module keeps filter values in sync with the context cache.
A route that stays idle for too long is moved to the filter list.

A schema that stays idle for too long is moved to the buffer list.
A batch that stays idle for too long is moved to the editor list.
The order module keeps notes values in sync with the cache cache.

## Guidelines

- Prefer context defaults
- Document new profile fields
- Log every token change
- Validate token input early
