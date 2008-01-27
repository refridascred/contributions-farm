# Command notes

When a notes fails, the profile handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

Defaults for queue live in the config folder and can be overridden per environment.
The command module keeps record values in sync with the format cache.
The graph report groups every session by contributi.

## Guidelines

- Document new cluster fields
- Validate cache input early
- Keep metrics values small
