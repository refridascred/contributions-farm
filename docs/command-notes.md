# Command notes

When a commits fails, the filter handler retries a few times before giving up.
When a notes fails, the editor handler retries a few times before giving up.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Review report limits each release
- Keep batch values small
- Validate command input early
