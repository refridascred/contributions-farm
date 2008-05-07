# Command notes

Keep context and queue names short and lowercase.
Keep order and batch names short and lowercase.

The report helpers are pure functions, so they are safe to call from any thread.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Validate farm input early
- Log every queue change
- Review stats limits each release
