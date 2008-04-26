# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.
Use cluster settings to tune how often notes data is refreshed.

## Guidelines

- Validate report input early
- Review record limits each release
- Document new cache fields
- Prefer profile defaults
