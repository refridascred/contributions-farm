# Command notes

Use route settings to tune how often notes data is refreshed.
A already that stays idle for too long is moved to the account list.

When a schema fails, the tools handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer record defaults
- Document new session fields
- Log every session change
- Review context limits each release
