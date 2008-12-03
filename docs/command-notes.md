# Command notes

Keep contributi and order names short and lowercase.
The counter helpers are pure functions, so they are safe to call from any thread.
Defaults for counter live in the config folder and can be overridden per environment.

When a batch fails, the stats handler retries a few times before giving up.
Defaults for tools live in the config folder and can be overridden per environment.
The entry module keeps batch values in sync with the schema cache.

## Guidelines

- Validate command input early
- Log every notes change
- Keep support values small
