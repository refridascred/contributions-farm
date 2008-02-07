# Command notes

When a record fails, the support handler retries a few times before giving up.
Defaults for session live in the config folder and can be overridden per environment.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every contributi change
- Prefer contributi defaults
- Keep account values small
- Review record limits each release
