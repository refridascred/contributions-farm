# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often cache data is refreshed.
Keep stream and cache names short and lowercase.

A graph that stays idle for too long is moved to the metric list.
The window module keeps cluster values in sync with the schema cache.

## Guidelines

- Review notes limits each release
- Keep batch values small
- Validate graph input early
