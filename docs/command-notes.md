# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for graph live in the config folder and can be overridden per environment.
Use graph settings to tune how often session data is refreshed.

## Guidelines

- Review payload limits each release
- Keep buffer values small
- Log every window change
- Prefer metric defaults
