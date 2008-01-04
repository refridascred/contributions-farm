# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
When a report fails, the token handler retries a few times before giving up.
The queue report groups every payload by stats.

Defaults for commits live in the config folder and can be overridden per environment.
Keep profile and window names short and lowercase.
When a session fails, the buffer handler retries a few times before giving up.

## Guidelines

- Validate githubfarm input early
- Prefer command defaults
- Document new buffer fields
- Review entry limits each release
