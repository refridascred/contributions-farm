# Command notes

When a cache fails, the cache handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.
The batches report groups every githubfarm by farm.

## Guidelines

- Keep cache values small
- Prefer route defaults
- Log every batches change
- Review window limits each release
