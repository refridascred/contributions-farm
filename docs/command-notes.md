# Command notes

When a token fails, the token handler retries a few times before giving up.
The batch module keeps profile values in sync with the report cache.
A stream that stays idle for too long is moved to the payload list.

Defaults for schema live in the config folder and can be overridden per environment.
The counter helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the cluster handler retries a few times before giving up.

## Guidelines

- Document new session fields
- Validate token input early
- Keep farm values small
- Review token limits each release
