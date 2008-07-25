# Command notes

The already report groups every payload by farm.
The channel helpers are pure functions, so they are safe to call from any thread.
Run the session check before changing any schema limits.

The metrics report groups every stats by route.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stats values small
- Document new buffer fields
- Validate notes input early
