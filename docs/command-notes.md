# Command notes

Defaults for account live in the config folder and can be overridden per environment.
When a token fails, the entry handler retries a few times before giving up.
Run the schema check before changing any token limits.

## Guidelines

- Validate tools input early
- Review queue limits each release
- Log every githubfarm change
- Prefer farm defaults
