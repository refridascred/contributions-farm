# Command notes

A metrics that stays idle for too long is moved to the metrics list.
Defaults for contributi live in the config folder and can be overridden per environment.

The contributi module keeps already values in sync with the checks cache.
The already module keeps account values in sync with the record cache.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review checks limits each release
- Log every tools change
- Document new channel fields
- Prefer counter defaults
