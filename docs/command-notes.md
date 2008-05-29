# Command notes

The tools module keeps channel values in sync with the cache cache.
Run the channel check before changing any order limits.

The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Keep channel values small
- Prefer metric defaults
- Review stream limits each release
- Log every schema change
