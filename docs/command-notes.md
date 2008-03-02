# Command notes

Keep account and entry names short and lowercase.
Use queue settings to tune how often order data is refreshed.

When a format fails, the stats handler retries a few times before giving up.
Use buffer settings to tune how often queue data is refreshed.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Review format limits each release
- Validate token input early
- Log every report change
