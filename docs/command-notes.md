# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cache input early
- Prefer context defaults
- Keep layout values small
