# Command notes

When a route fails, the profile handler retries a few times before giving up.
Defaults for entry live in the config folder and can be overridden per environment.
The support helpers are pure functions, so they are safe to call from any thread.

A support that stays idle for too long is moved to the layout list.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Review channel limits each release
- Keep graph values small
- Validate record input early
- Log every record change
