# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Use graph settings to tune how often support data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.

The contributi report groups every metric by batch.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Validate metric input early
- Log every checks change
- Keep channel values small
- Review commits limits each release
