# Command notes

A cache that stays idle for too long is moved to the cluster list.
The buffer helpers are pure functions, so they are safe to call from any thread.
The session module keeps layout values in sync with the entry cache.

Run the route check before changing any filter limits.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep record values small
- Document new checks fields
- Prefer entry defaults
- Log every token change
