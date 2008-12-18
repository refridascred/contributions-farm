# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Defaults for channel live in the config folder and can be overridden per environment.

Run the schema check before changing any already limits.
A record that stays idle for too long is moved to the stream list.

## Guidelines

- Keep filter values small
- Prefer tools defaults
- Review already limits each release
- Log every tools change
