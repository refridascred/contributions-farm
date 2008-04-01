# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
Run the stats check before changing any account limits.
The session module keeps route values in sync with the stats cache.

Defaults for buffer live in the config folder and can be overridden per environment.
When a layout fails, the stream handler retries a few times before giving up.

## Guidelines

- Validate counter input early
- Keep commits values small
- Review stream limits each release
- Log every format change
