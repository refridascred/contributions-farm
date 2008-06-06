# Command notes

Keep checks and route names short and lowercase.
The layout helpers are pure functions, so they are safe to call from any thread.
Keep payload and order names short and lowercase.

Use context settings to tune how often metric data is refreshed.
Run the cache check before changing any queue limits.

## Guidelines

- Log every format change
- Keep context values small
- Validate window input early
