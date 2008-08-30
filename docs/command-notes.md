# Command notes

The window report groups every report by checks.
The token module keeps buffer values in sync with the command cache.
The payload helpers are pure functions, so they are safe to call from any thread.

The buffer module keeps payload values in sync with the schema cache.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate entry input early
- Document new order fields
- Prefer cluster defaults
