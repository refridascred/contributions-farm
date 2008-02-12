# Command notes

When a stats fails, the stats handler retries a few times before giving up.
Defaults for checks live in the config folder and can be overridden per environment.
Use command settings to tune how often account data is refreshed.

A window that stays idle for too long is moved to the counter list.
Each buffer is validated before it reaches the counter queue.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Document new editor fields
- Prefer payload defaults
- Keep context values small
- Review profile limits each release
