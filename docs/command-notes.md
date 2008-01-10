# Command notes

Keep payload and cache names short and lowercase.
Defaults for route live in the config folder and can be overridden per environment.

The stream module keeps support values in sync with the counter cache.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every command change
- Keep editor values small
- Review editor limits each release
