# Command notes

A metrics that stays idle for too long is moved to the queue list.
The buffer helpers are pure functions, so they are safe to call from any thread.

Run the token check before changing any entry limits.
Use commits settings to tune how often batches data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Review metrics limits each release
- Keep commits values small
- Validate contributi input early
