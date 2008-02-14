# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
Use buffer settings to tune how often account data is refreshed.

The stats helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.
A commits that stays idle for too long is moved to the format list.

## Guidelines

- Log every contributi change
- Document new session fields
- Validate buffer input early
- Keep session values small
