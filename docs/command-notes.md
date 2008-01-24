# Command notes

When a batch fails, the filter handler retries a few times before giving up.
Defaults for session live in the config folder and can be overridden per environment.

The buffer report groups every farm by tools.
Run the buffer check before changing any token limits.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Keep report values small
- Validate command input early
- Review record limits each release
