# Command notes

Use route settings to tune how often session data is refreshed.
A format that stays idle for too long is moved to the metrics list.

The notes helpers are pure functions, so they are safe to call from any thread.
Keep command and window names short and lowercase.

## Guidelines

- Document new schema fields
- Validate support input early
- Prefer metrics defaults
- Review cache limits each release
