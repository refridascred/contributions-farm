# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often route data is refreshed.

Use queue settings to tune how often profile data is refreshed.
A support that stays idle for too long is moved to the already list.

## Guidelines

- Prefer layout defaults
- Log every cache change
- Document new account fields
