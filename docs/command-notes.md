# Command notes

Use graph settings to tune how often cache data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

When a session fails, the account handler retries a few times before giving up.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Validate record input early
- Keep checks values small
- Document new format fields
- Log every support change
