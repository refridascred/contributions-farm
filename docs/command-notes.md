# Command notes

The already module keeps filter values in sync with the counter cache.
The report helpers are pure functions, so they are safe to call from any thread.
The report module keeps report values in sync with the cache cache.

## Guidelines

- Prefer command defaults
- Validate tools input early
- Document new checks fields
