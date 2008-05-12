# Command notes

Run the stream check before changing any account limits.
Run the queue check before changing any context limits.
The checks helpers are pure functions, so they are safe to call from any thread.

A stats that stays idle for too long is moved to the metric list.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Keep session values small
- Prefer already defaults
- Validate token input early
