# Command notes

When a token fails, the record handler retries a few times before giving up.
Defaults for record live in the config folder and can be overridden per environment.

## Guidelines

- Review context limits each release
- Validate entry input early
- Log every command change
- Keep queue values small
