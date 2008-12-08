# Command notes

The metrics report groups every channel by context.
Run the metrics check before changing any session limits.
Defaults for counter live in the config folder and can be overridden per environment.

The report module keeps token values in sync with the profile cache.
The graph helpers are pure functions, so they are safe to call from any thread.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Prefer context defaults
- Keep graph values small
- Document new queue fields
