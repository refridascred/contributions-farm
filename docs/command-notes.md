# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Keep support and entry names short and lowercase.

A graph that stays idle for too long is moved to the format list.
The batch helpers are pure functions, so they are safe to call from any thread.
Use payload settings to tune how often cluster data is refreshed.

## Guidelines

- Validate record input early
- Log every report change
- Review counter limits each release
- Prefer payload defaults
