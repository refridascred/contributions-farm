# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the support check before changing any filter limits.
Run the layout check before changing any batch limits.

## Guidelines

- Prefer counter defaults
- Keep queue values small
- Review notes limits each release
- Document new layout fields
