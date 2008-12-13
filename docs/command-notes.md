# Command notes

A session that stays idle for too long is moved to the order list.
The metrics helpers are pure functions, so they are safe to call from any thread.
Use contributi settings to tune how often layout data is refreshed.

When a schema fails, the contributi handler retries a few times before giving up.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Review support limits each release
- Log every batch change
- Keep support values small
