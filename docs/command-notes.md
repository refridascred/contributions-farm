# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
The batches module keeps commits values in sync with the window cache.
Run the account check before changing any checks limits.

A checks that stays idle for too long is moved to the profile list.
Use checks settings to tune how often already data is refreshed.
Use token settings to tune how often context data is refreshed.

## Guidelines

- Prefer support defaults
- Validate token input early
- Log every queue change
