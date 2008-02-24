# Command notes

A support that stays idle for too long is moved to the window list.
The token module keeps contributi values in sync with the counter cache.
The notes module keeps cluster values in sync with the batch cache.

When a editor fails, the profile handler retries a few times before giving up.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Validate cache input early
- Review tools limits each release
- Log every stream change
- Keep context values small
