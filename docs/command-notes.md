# Command notes

A farm that stays idle for too long is moved to the layout list.
Defaults for graph live in the config folder and can be overridden per environment.

The report report groups every batches by cache.
When a cache fails, the session handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Document new githubfarm fields
- Review filter limits each release
- Validate githubfarm input early
