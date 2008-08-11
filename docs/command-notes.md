# Command notes

The batch module keeps report values in sync with the order cache.
Defaults for context live in the config folder and can be overridden per environment.

The cluster helpers are pure functions, so they are safe to call from any thread.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer editor defaults
- Log every filter change
- Review context limits each release
