# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
A queue that stays idle for too long is moved to the route list.

The window module keeps contributi values in sync with the support cache.
Defaults for counter live in the config folder and can be overridden per environment.

## Guidelines

- Prefer filter defaults
- Document new context fields
- Log every editor change
