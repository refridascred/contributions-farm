# Command notes

A tools that stays idle for too long is moved to the profile list.
The order module keeps payload values in sync with the order cache.
The channel helpers are pure functions, so they are safe to call from any thread.

The graph helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep order values small
- Log every metrics change
- Validate window input early
