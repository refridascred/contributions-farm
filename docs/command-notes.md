# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any graph limits.
Use support settings to tune how often session data is refreshed.

The layout report groups every order by record.
Each report is validated before it reaches the context queue.

## Guidelines

- Keep farm values small
- Log every tools change
- Validate report input early
- Review commits limits each release
