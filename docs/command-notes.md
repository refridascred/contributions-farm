# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
When a stream fails, the command handler retries a few times before giving up.

Use farm settings to tune how often channel data is refreshed.
Use route settings to tune how often profile data is refreshed.
The account module keeps cache values in sync with the cache cache.

## Guidelines

- Review graph limits each release
- Log every order change
- Prefer format defaults
- Keep batch values small
