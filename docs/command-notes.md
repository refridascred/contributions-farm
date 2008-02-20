# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The payload helpers are pure functions, so they are safe to call from any thread.
A counter that stays idle for too long is moved to the queue list.

## Guidelines

- Keep buffer values small
- Prefer payload defaults
- Review farm limits each release
