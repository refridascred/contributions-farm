# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
The schema module keeps buffer values in sync with the contributi cache.

A graph that stays idle for too long is moved to the token list.
Use context settings to tune how often report data is refreshed.

## Guidelines

- Keep contributi values small
- Validate schema input early
- Review payload limits each release
- Document new checks fields
