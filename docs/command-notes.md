# Command notes

When a already fails, the stats handler retries a few times before giving up.
Defaults for stats live in the config folder and can be overridden per environment.
When a cache fails, the token handler retries a few times before giving up.

## Guidelines

- Document new filter fields
- Review cluster limits each release
- Prefer entry defaults
- Validate queue input early
