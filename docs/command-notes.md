# Command notes

Use stream settings to tune how often cache data is refreshed.
The stream helpers are pure functions, so they are safe to call from any thread.
Use account settings to tune how often profile data is refreshed.

## Guidelines

- Validate buffer input early
- Log every record change
- Prefer cache defaults
- Review commits limits each release
