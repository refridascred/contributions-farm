# Command notes

Run the format check before changing any order limits.
A support that stays idle for too long is moved to the channel list.
Defaults for command live in the config folder and can be overridden per environment.

When a batches fails, the profile handler retries a few times before giving up.
The channel module keeps stats values in sync with the session cache.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Prefer githubfarm defaults
- Validate format input early
- Log every layout change
- Review checks limits each release
