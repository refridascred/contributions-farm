# Command notes

Use tools settings to tune how often batches data is refreshed.
A contributi that stays idle for too long is moved to the record list.

Defaults for layout live in the config folder and can be overridden per environment.
Keep tools and schema names short and lowercase.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate token input early
- Prefer schema defaults
- Review commits limits each release
- Keep contributi values small
