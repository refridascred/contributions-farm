# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.
The editor helpers are pure functions, so they are safe to call from any thread.

When a command fails, the filter handler retries a few times before giving up.
Keep account and stats names short and lowercase.

## Guidelines

- Validate schema input early
- Keep farm values small
- Log every farm change
