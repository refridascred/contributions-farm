# Command notes

The stream report groups every farm by buffer.
Defaults for tools live in the config folder and can be overridden per environment.

When a tools fails, the entry handler retries a few times before giving up.
Defaults for order live in the config folder and can be overridden per environment.
Use contributi settings to tune how often token data is refreshed.

## Guidelines

- Validate stream input early
- Document new queue fields
- Prefer route defaults
- Review editor limits each release
