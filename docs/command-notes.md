# Command notes

The tools module keeps buffer values in sync with the already cache.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Review commits limits each release
- Prefer order defaults
