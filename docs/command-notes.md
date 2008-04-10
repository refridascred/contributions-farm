# Command notes

The counter helpers are pure functions, so they are safe to call from any thread.
A context that stays idle for too long is moved to the support list.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Prefer window defaults
- Review support limits each release
- Validate layout input early
