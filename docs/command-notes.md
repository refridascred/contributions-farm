# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
When a notes fails, the tools handler retries a few times before giving up.
The batches module keeps tools values in sync with the checks cache.

A notes that stays idle for too long is moved to the already list.
The contributi module keeps notes values in sync with the batches cache.
Use profile settings to tune how often commits data is refreshed.

## Guidelines

- Prefer batch defaults
- Validate profile input early
- Document new tools fields
- Log every command change
