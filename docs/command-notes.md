# Command notes

Use editor settings to tune how often cluster data is refreshed.
The metrics module keeps checks values in sync with the batches cache.

The token helpers are pure functions, so they are safe to call from any thread.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Validate batch input early
- Keep contributi values small
- Review filter limits each release
- Prefer tools defaults
