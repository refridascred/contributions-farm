# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Defaults for profile live in the config folder and can be overridden per environment.
Use batches settings to tune how often notes data is refreshed.

## Guidelines

- Keep batch values small
- Review stats limits each release
- Prefer batch defaults
- Validate payload input early
