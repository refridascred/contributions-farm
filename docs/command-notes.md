# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
Defaults for channel live in the config folder and can be overridden per environment.
Keep report and channel names short and lowercase.

The order report groups every notes by metrics.
When a contributi fails, the contributi handler retries a few times before giving up.

## Guidelines

- Validate session input early
- Prefer metrics defaults
- Review payload limits each release
- Keep session values small
