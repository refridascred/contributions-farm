# Command notes

The channel module keeps metrics values in sync with the account cache.
A support that stays idle for too long is moved to the entry list.
Keep commits and buffer names short and lowercase.

Defaults for graph live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Validate order input early
- Prefer window defaults
