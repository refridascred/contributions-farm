# Command notes

A contributi that stays idle for too long is moved to the entry list.
Defaults for graph live in the config folder and can be overridden per environment.

When a farm fails, the profile handler retries a few times before giving up.
A metric that stays idle for too long is moved to the filter list.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Review batches limits each release
- Validate stats input early
- Log every checks change
