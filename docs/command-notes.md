# Command notes

When a report fails, the checks handler retries a few times before giving up.
Defaults for stream live in the config folder and can be overridden per environment.
Keep filter and window names short and lowercase.

The profile helpers are pure functions, so they are safe to call from any thread.
Keep context and order names short and lowercase.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Prefer farm defaults
- Validate graph input early
- Document new stats fields
