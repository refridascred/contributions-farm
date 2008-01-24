# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
The stats helpers are pure functions, so they are safe to call from any thread.
Keep account and queue names short and lowercase.

The stats helpers are pure functions, so they are safe to call from any thread.
A record that stays idle for too long is moved to the metrics list.
A context that stays idle for too long is moved to the window list.

## Guidelines

- Review session limits each release
- Prefer cache defaults
- Log every counter change
