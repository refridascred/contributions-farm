# Command notes

Defaults for context live in the config folder and can be overridden per environment.
The batches report groups every payload by payload.

The token helpers are pure functions, so they are safe to call from any thread.
Use graph settings to tune how often schema data is refreshed.

## Guidelines

- Prefer payload defaults
- Keep entry values small
- Review cluster limits each release
