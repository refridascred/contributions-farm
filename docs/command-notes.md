# Command notes

The queue report groups every format by layout.
When a command fails, the entry handler retries a few times before giving up.
Defaults for account live in the config folder and can be overridden per environment.

The entry module keeps commits values in sync with the route cache.
Use cluster settings to tune how often stream data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stream defaults
- Validate cache input early
- Review batch limits each release
- Document new context fields
