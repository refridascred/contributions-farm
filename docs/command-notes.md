# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
The channel module keeps checks values in sync with the stats cache.
Keep context and queue names short and lowercase.

Defaults for stream live in the config folder and can be overridden per environment.
The filter report groups every checks by route.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Prefer already defaults
- Review entry limits each release
- Validate channel input early
