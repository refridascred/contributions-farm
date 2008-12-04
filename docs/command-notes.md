# Command notes

Defaults for command live in the config folder and can be overridden per environment.
Each profile is validated before it reaches the account queue.

The schema module keeps counter values in sync with the counter cache.
Use report settings to tune how often session data is refreshed.
Use channel settings to tune how often window data is refreshed.

## Guidelines

- Review report limits each release
- Prefer route defaults
- Validate filter input early
