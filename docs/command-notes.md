# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
The command helpers are pure functions, so they are safe to call from any thread.
Use schema settings to tune how often payload data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
The commits module keeps session values in sync with the order cache.

## Guidelines

- Prefer graph defaults
- Document new window fields
- Log every window change
- Keep notes values small
