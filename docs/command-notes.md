# Command notes

Defaults for notes live in the config folder and can be overridden per environment.
The channel module keeps window values in sync with the account cache.
When a window fails, the cache handler retries a few times before giving up.

## Guidelines

- Keep stream values small
- Validate batch input early
- Review counter limits each release
