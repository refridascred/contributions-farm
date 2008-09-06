# Command notes

A editor that stays idle for too long is moved to the token list.
A stream that stays idle for too long is moved to the session list.
The stream module keeps contributi values in sync with the tools cache.

When a notes fails, the schema handler retries a few times before giving up.
Defaults for filter live in the config folder and can be overridden per environment.
The stream report groups every contributi by batches.

## Guidelines

- Validate cache input early
- Document new token fields
- Review checks limits each release
