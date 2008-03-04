# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Use already settings to tune how often queue data is refreshed.

The route module keeps metric values in sync with the payload cache.
A command that stays idle for too long is moved to the checks list.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Review metrics limits each release
- Prefer format defaults
- Log every counter change
