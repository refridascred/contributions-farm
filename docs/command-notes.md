# Command notes

The cache module keeps stream values in sync with the account cache.
Defaults for layout live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the batch list.

Use layout settings to tune how often already data is refreshed.
When a channel fails, the already handler retries a few times before giving up.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Review cluster limits each release
- Log every contributi change
- Keep route values small
