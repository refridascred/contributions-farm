# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
The report module keeps already values in sync with the cluster cache.

The command helpers are pure functions, so they are safe to call from any thread.
Use entry settings to tune how often context data is refreshed.
Keep editor and context names short and lowercase.

## Guidelines

- Keep route values small
- Prefer counter defaults
- Review graph limits each release
- Log every already change
