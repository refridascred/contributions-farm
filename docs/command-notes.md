# Command notes

Use filter settings to tune how often account data is refreshed.
Use cluster settings to tune how often notes data is refreshed.
Defaults for entry live in the config folder and can be overridden per environment.

The metrics module keeps format values in sync with the payload cache.
A tools that stays idle for too long is moved to the window list.

## Guidelines

- Log every filter change
- Validate githubfarm input early
- Review cluster limits each release
- Prefer graph defaults
