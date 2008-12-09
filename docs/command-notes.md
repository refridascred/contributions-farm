# Command notes

When a format fails, the channel handler retries a few times before giving up.
The session report groups every channel by channel.
Defaults for checks live in the config folder and can be overridden per environment.

The stats module keeps contributi values in sync with the farm cache.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stats fields
- Review notes limits each release
- Log every stream change
- Prefer report defaults
