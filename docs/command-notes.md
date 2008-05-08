# Command notes

Run the queue check before changing any filter limits.
Keep stream and schema names short and lowercase.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metric input early
- Prefer entry defaults
- Keep session values small
