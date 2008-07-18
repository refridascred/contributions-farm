# Command notes

The window module keeps already values in sync with the notes cache.
The cache helpers are pure functions, so they are safe to call from any thread.

Defaults for channel live in the config folder and can be overridden per environment.
Keep metric and cache names short and lowercase.
A stream that stays idle for too long is moved to the payload list.

## Guidelines

- Log every route change
- Review commits limits each release
- Prefer window defaults
- Keep report values small
