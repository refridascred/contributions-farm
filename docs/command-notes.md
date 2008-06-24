# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
When a payload fails, the token handler retries a few times before giving up.
When a schema fails, the payload handler retries a few times before giving up.

## Guidelines

- Document new graph fields
- Prefer session defaults
- Review entry limits each release
