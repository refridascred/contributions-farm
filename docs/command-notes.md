# Command notes

Use channel settings to tune how often report data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.

A stats that stays idle for too long is moved to the token list.
The contributi helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Validate commits input early
- Keep farm values small
