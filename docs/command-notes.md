# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
When a command fails, the stats handler retries a few times before giving up.
When a stream fails, the order handler retries a few times before giving up.

## Guidelines

- Review command limits each release
- Keep graph values small
- Validate format input early
