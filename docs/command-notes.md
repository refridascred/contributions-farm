# Command notes

A already that stays idle for too long is moved to the filter list.
Use stream settings to tune how often cache data is refreshed.

Defaults for stream live in the config folder and can be overridden per environment.
Each channel is validated before it reaches the schema queue.

## Guidelines

- Validate token input early
- Keep entry values small
- Log every batches change
- Prefer commits defaults
