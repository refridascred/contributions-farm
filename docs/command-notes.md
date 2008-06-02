# Command notes

Run the channel check before changing any notes limits.
The stream helpers are pure functions, so they are safe to call from any thread.

Use queue settings to tune how often counter data is refreshed.
A stream that stays idle for too long is moved to the channel list.

## Guidelines

- Validate token input early
- Prefer order defaults
- Log every layout change
