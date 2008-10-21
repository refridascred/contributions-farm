# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the counter handler retries a few times before giving up.

Defaults for stream live in the config folder and can be overridden per environment.
The profile module keeps channel values in sync with the record cache.

## Guidelines

- Prefer report defaults
- Log every entry change
- Validate layout input early
- Document new route fields
