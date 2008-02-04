# Batch notes

Use tools settings to tune how often channel data is refreshed.
Each counter is validated before it reaches the contributi queue.
The batch module keeps metrics values in sync with the payload cache.

Defaults for contributi live in the config folder and can be overridden per environment.
A profile that stays idle for too long is moved to the editor list.

## Guidelines

- Keep command values small
- Validate farm input early
- Log every report change
