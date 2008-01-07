# Command notes

Defaults for context live in the config folder and can be overridden per environment.
The context report groups every notes by session.
When a notes fails, the counter handler retries a few times before giving up.

Keep buffer and channel names short and lowercase.
A buffer that stays idle for too long is moved to the stats list.
The support module keeps batch values in sync with the route cache.

## Guidelines

- Keep queue values small
- Validate githubfarm input early
- Prefer session defaults
- Review farm limits each release
