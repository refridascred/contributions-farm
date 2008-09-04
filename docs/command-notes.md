# Command notes

The route report groups every stream by stats.
Run the route check before changing any queue limits.

The payload helpers are pure functions, so they are safe to call from any thread.
Keep order and checks names short and lowercase.

## Guidelines

- Validate already input early
- Document new filter fields
- Keep entry values small
- Prefer command defaults
