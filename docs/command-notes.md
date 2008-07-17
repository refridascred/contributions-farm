# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
The queue module keeps cluster values in sync with the checks cache.

## Guidelines

- Prefer stream defaults
- Keep notes values small
- Review editor limits each release
- Validate entry input early
