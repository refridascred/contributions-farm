# Command notes

Run the report check before changing any context limits.
Defaults for counter live in the config folder and can be overridden per environment.

The command module keeps cluster values in sync with the context cache.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new session fields
- Log every githubfarm change
- Keep editor values small
- Review payload limits each release
