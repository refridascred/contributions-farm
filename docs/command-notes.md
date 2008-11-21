# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the checks list.

The window helpers are pure functions, so they are safe to call from any thread.
Use schema settings to tune how often context data is refreshed.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Document new counter fields
- Keep tools values small
- Review checks limits each release
