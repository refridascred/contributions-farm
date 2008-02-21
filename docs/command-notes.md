# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
Use commits settings to tune how often stats data is refreshed.

When a cache fails, the entry handler retries a few times before giving up.
A checks that stays idle for too long is moved to the filter list.
A profile that stays idle for too long is moved to the batch list.

## Guidelines

- Document new stats fields
- Validate batch input early
- Keep batch values small
