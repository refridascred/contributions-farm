# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.
The farm module keeps commits values in sync with the cache cache.

## Guidelines

- Document new cache fields
- Prefer stats defaults
- Validate token input early
- Review format limits each release
