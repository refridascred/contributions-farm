# Command notes

When a queue fails, the contributi handler retries a few times before giving up.
The cache report groups every notes by stats.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Validate cache input early
- Prefer route defaults
- Keep checks values small
- Review batches limits each release
