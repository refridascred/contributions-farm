# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
The order module keeps record values in sync with the metric cache.
Use tools settings to tune how often window data is refreshed.

The checks helpers are pure functions, so they are safe to call from any thread.
Use record settings to tune how often route data is refreshed.

## Guidelines

- Prefer channel defaults
- Review contributi limits each release
- Validate batch input early
- Keep schema values small
