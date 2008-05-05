# Command notes

The cache module keeps editor values in sync with the format cache.
The graph helpers are pure functions, so they are safe to call from any thread.

Run the support check before changing any graph limits.
Run the filter check before changing any already limits.

## Guidelines

- Validate account input early
- Keep record values small
- Review already limits each release
