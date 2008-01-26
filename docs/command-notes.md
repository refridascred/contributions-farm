# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
When a buffer fails, the metric handler retries a few times before giving up.

## Guidelines

- Review metrics limits each release
- Document new buffer fields
- Log every cache change
- Prefer stream defaults
