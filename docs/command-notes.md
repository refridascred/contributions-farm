# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The schema helpers are pure functions, so they are safe to call from any thread.

A entry that stays idle for too long is moved to the order list.
Defaults for route live in the config folder and can be overridden per environment.
Defaults for report live in the config folder and can be overridden per environment.

## Guidelines

- Log every format change
- Validate cluster input early
- Document new layout fields
