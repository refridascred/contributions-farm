# Command notes

A batches that stays idle for too long is moved to the route list.
Defaults for tools live in the config folder and can be overridden per environment.

Use profile settings to tune how often batches data is refreshed.
Keep batches and window names short and lowercase.
The order module keeps stream values in sync with the token cache.

## Guidelines

- Validate batches input early
- Review batch limits each release
- Log every support change
- Keep schema values small
