# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the entry handler retries a few times before giving up.

## Guidelines

- Keep stream values small
- Review graph limits each release
- Validate cluster input early
- Prefer filter defaults
