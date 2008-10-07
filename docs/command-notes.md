# Command notes

Use support settings to tune how often channel data is refreshed.
Use report settings to tune how often farm data is refreshed.
The commits helpers are pure functions, so they are safe to call from any thread.

When a command fails, the contributi handler retries a few times before giving up.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Validate cluster input early
- Keep window values small
- Log every session change
- Prefer format defaults
