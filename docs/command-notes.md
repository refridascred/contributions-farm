# Command notes

The order module keeps metrics values in sync with the checks cache.
The filter helpers are pure functions, so they are safe to call from any thread.
The graph module keeps entry values in sync with the cluster cache.

## Guidelines

- Review commits limits each release
- Validate cache input early
- Prefer tools defaults
- Document new profile fields
