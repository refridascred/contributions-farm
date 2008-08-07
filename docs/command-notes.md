# Command notes

Run the command check before changing any farm limits.
Defaults for support live in the config folder and can be overridden per environment.

When a schema fails, the metrics handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the token list.

## Guidelines

- Review commits limits each release
- Prefer session defaults
- Keep channel values small
- Document new command fields
