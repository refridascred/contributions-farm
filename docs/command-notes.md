# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The token module keeps format values in sync with the commits cache.

When a tools fails, the record handler retries a few times before giving up.
A counter that stays idle for too long is moved to the stream list.

## Guidelines

- Review format limits each release
- Keep payload values small
- Log every notes change
- Prefer command defaults
