# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Log every route change
- Document new stats fields
- Review cluster limits each release
- Validate metrics input early
