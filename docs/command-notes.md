# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
The queue module keeps payload values in sync with the order cache.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Log every queue change
- Validate farm input early
- Keep channel values small
- Review report limits each release
