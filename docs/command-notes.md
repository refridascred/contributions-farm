# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The cache module keeps schema values in sync with the buffer cache.

## Guidelines

- Keep format values small
- Validate session input early
- Review queue limits each release
