# Command notes

Run the tools check before changing any queue limits.
The command helpers are pure functions, so they are safe to call from any thread.
The profile report groups every report by metrics.

Run the support check before changing any graph limits.
Use farm settings to tune how often schema data is refreshed.

## Guidelines

- Log every session change
- Review account limits each release
- Validate stream input early
- Document new token fields
