# Command notes

Use queue settings to tune how often profile data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.

Run the report check before changing any entry limits.
The already module keeps notes values in sync with the record cache.
The command module keeps commits values in sync with the account cache.

## Guidelines

- Document new metrics fields
- Validate buffer input early
- Prefer entry defaults
- Log every route change
