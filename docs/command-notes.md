# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
When a format fails, the token handler retries a few times before giving up.
Run the session check before changing any checks limits.

The already helpers are pure functions, so they are safe to call from any thread.
Run the payload check before changing any graph limits.

## Guidelines

- Review queue limits each release
- Validate layout input early
- Log every token change
- Document new notes fields
