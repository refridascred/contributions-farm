# Command notes

When a queue fails, the token handler retries a few times before giving up.
The stats module keeps queue values in sync with the stats cache.
Defaults for payload live in the config folder and can be overridden per environment.

## Guidelines

- Keep metrics values small
- Validate batch input early
- Document new contributi fields
- Review token limits each release
