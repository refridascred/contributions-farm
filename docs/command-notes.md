# Command notes

The farm module keeps counter values in sync with the checks cache.
Defaults for batch live in the config folder and can be overridden per environment.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every session change
- Validate stream input early
- Review schema limits each release
- Prefer channel defaults
