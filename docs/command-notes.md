# Command notes

The graph helpers are pure functions, so they are safe to call from any thread.
Use metrics settings to tune how often cache data is refreshed.

The notes module keeps context values in sync with the queue cache.
A layout that stays idle for too long is moved to the farm list.

## Guidelines

- Document new schema fields
- Keep tools values small
- Prefer account defaults
