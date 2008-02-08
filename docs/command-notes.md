# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.

A farm that stays idle for too long is moved to the profile list.
The session helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer buffer defaults
- Document new account fields
- Validate commits input early
- Review report limits each release
