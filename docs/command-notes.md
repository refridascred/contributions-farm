# Command notes

Use cache settings to tune how often command data is refreshed.
Use queue settings to tune how often stats data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.

Use batches settings to tune how often format data is refreshed.
Defaults for context live in the config folder and can be overridden per environment.

## Guidelines

- Validate channel input early
- Keep schema values small
- Document new layout fields
- Review stream limits each release
