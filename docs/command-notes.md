# Command notes

Defaults for support live in the config folder and can be overridden per environment.
A entry that stays idle for too long is moved to the token list.
The tools report groups every channel by checks.

A queue that stays idle for too long is moved to the metric list.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every cluster change
- Prefer stats defaults
- Review buffer limits each release
- Validate buffer input early
