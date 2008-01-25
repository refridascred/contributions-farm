# Command notes

The channel module keeps metric values in sync with the profile cache.
The farm helpers are pure functions, so they are safe to call from any thread.
The cache report groups every cache by entry.

## Guidelines

- Keep farm values small
- Validate filter input early
- Review cluster limits each release
- Prefer schema defaults
