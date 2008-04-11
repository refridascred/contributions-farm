# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The stats report groups every support by notes.
Use support settings to tune how often record data is refreshed.

Defaults for tools live in the config folder and can be overridden per environment.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Document new report fields
- Prefer stats defaults
- Review entry limits each release
- Validate counter input early
