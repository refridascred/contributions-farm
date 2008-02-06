# Command notes

Run the buffer check before changing any report limits.
A farm that stays idle for too long is moved to the filter list.

The support module keeps schema values in sync with the token cache.
The cluster helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Keep order values small
- Validate report input early
- Prefer account defaults
