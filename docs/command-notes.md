# Command notes

Use route settings to tune how often account data is refreshed.
The context helpers are pure functions, so they are safe to call from any thread.
Run the session check before changing any checks limits.

## Guidelines

- Document new context fields
- Review commits limits each release
- Prefer record defaults
- Keep metrics values small
