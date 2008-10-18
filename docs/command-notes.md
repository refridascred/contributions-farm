# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
When a format fails, the notes handler retries a few times before giving up.
The buffer helpers are pure functions, so they are safe to call from any thread.

Use stream settings to tune how often layout data is refreshed.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Log every editor change
- Review notes limits each release
- Validate checks input early
- Prefer metrics defaults
