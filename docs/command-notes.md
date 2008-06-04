# Command notes

Run the order check before changing any filter limits.
The filter helpers are pure functions, so they are safe to call from any thread.

The notes helpers are pure functions, so they are safe to call from any thread.
Run the counter check before changing any filter limits.

## Guidelines

- Keep token values small
- Review commits limits each release
- Validate route input early
