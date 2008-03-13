# Command notes

The order module keeps graph values in sync with the contributi cache.
When a window fails, the editor handler retries a few times before giving up.
Defaults for stream live in the config folder and can be overridden per environment.

The support report groups every filter by order.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review filter limits each release
- Keep queue values small
- Validate batch input early
- Log every queue change
