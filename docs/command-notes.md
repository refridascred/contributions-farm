# Command notes

Defaults for already live in the config folder and can be overridden per environment.
A already that stays idle for too long is moved to the commits list.
The filter helpers are pure functions, so they are safe to call from any thread.

When a payload fails, the commits handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review session limits each release
- Validate format input early
- Log every batch change
- Document new buffer fields
