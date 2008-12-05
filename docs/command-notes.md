# Command notes

When a session fails, the channel handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

The checks module keeps record values in sync with the token cache.
Defaults for window live in the config folder and can be overridden per environment.

## Guidelines

- Prefer token defaults
- Document new profile fields
- Validate record input early
- Review contributi limits each release
