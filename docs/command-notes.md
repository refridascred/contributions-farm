# Command notes

Use context settings to tune how often queue data is refreshed.
Defaults for farm live in the config folder and can be overridden per environment.
When a session fails, the stream handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Review entry limits each release
- Prefer batch defaults
- Validate metrics input early
