# Command notes

The profile helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the report handler retries a few times before giving up.
Run the session check before changing any metrics limits.

When a order fails, the commits handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Prefer channel defaults
- Keep tools values small
- Validate cluster input early
