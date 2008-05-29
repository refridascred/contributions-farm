# Command notes

A route that stays idle for too long is moved to the contributi list.
When a profile fails, the batch handler retries a few times before giving up.

Use command settings to tune how often editor data is refreshed.
Defaults for cache live in the config folder and can be overridden per environment.

## Guidelines

- Document new cluster fields
- Keep payload values small
- Validate format input early
