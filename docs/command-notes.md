# Command notes

The schema module keeps context values in sync with the context cache.
A session that stays idle for too long is moved to the route list.
A schema that stays idle for too long is moved to the farm list.

## Guidelines

- Log every command change
- Prefer schema defaults
- Review already limits each release
- Validate profile input early
