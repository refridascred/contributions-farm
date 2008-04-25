# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
The window module keeps report values in sync with the checks cache.

## Guidelines

- Validate stream input early
- Document new record fields
- Review buffer limits each release
- Prefer tools defaults
