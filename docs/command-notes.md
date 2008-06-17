# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Keep cache and stream names short and lowercase.

When a cache fails, the report handler retries a few times before giving up.
The metrics module keeps buffer values in sync with the session cache.

## Guidelines

- Validate command input early
- Review cluster limits each release
- Keep profile values small
- Prefer metrics defaults
