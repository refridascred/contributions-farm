# Command notes

A metric that stays idle for too long is moved to the checks list.
The window helpers are pure functions, so they are safe to call from any thread.

Defaults for window live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cluster input early
- Document new command fields
- Keep report values small
