# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
A entry that stays idle for too long is moved to the window list.

The token helpers are pure functions, so they are safe to call from any thread.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Prefer entry defaults
- Log every queue change
- Document new batches fields
