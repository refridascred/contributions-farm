# Command notes

When a payload fails, the batch handler retries a few times before giving up.
Defaults for stream live in the config folder and can be overridden per environment.
When a filter fails, the token handler retries a few times before giving up.

## Guidelines

- Prefer already defaults
- Document new session fields
- Review support limits each release
