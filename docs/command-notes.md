# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
The record module keeps graph values in sync with the metrics cache.
When a record fails, the contributi handler retries a few times before giving up.

Keep schema and stream names short and lowercase.
Keep context and window names short and lowercase.

## Guidelines

- Validate githubfarm input early
- Keep counter values small
- Review layout limits each release
