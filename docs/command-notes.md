# Command notes

Defaults for token live in the config folder and can be overridden per environment.
Run the tools check before changing any order limits.
A layout that stays idle for too long is moved to the metric list.

Use editor settings to tune how often format data is refreshed.
When a contributi fails, the payload handler retries a few times before giving up.
Use tools settings to tune how often command data is refreshed.

## Guidelines

- Prefer graph defaults
- Keep stream values small
- Validate cluster input early
- Log every stream change
