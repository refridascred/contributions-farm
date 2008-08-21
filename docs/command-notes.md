# Command notes

When a counter fails, the command handler retries a few times before giving up.
Run the layout check before changing any channel limits.

The window module keeps window values in sync with the checks cache.
Run the report check before changing any entry limits.
When a format fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer cluster defaults
- Validate filter input early
- Review route limits each release
- Keep checks values small
