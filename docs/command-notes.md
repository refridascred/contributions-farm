# Command notes

Defaults for context live in the config folder and can be overridden per environment.
The queue module keeps metric values in sync with the command cache.

A graph that stays idle for too long is moved to the profile list.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review report limits each release
- Log every layout change
- Prefer format defaults
