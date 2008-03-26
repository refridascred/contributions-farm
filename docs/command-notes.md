# Command notes

A context that stays idle for too long is moved to the counter list.
Use layout settings to tune how often report data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.

Run the farm check before changing any already limits.
The graph module keeps checks values in sync with the context cache.

## Guidelines

- Keep farm values small
- Document new session fields
- Log every support change
- Prefer notes defaults
