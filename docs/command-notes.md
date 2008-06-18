# Command notes

The stream module keeps contributi values in sync with the context cache.
Defaults for cluster live in the config folder and can be overridden per environment.
A token that stays idle for too long is moved to the farm list.

## Guidelines

- Log every filter change
- Keep entry values small
- Validate queue input early
- Prefer command defaults
