# Command notes

Defaults for stats live in the config folder and can be overridden per environment.
The tools helpers are pure functions, so they are safe to call from any thread.

Defaults for account live in the config folder and can be overridden per environment.
Each stream is validated before it reaches the stats queue.

## Guidelines

- Prefer order defaults
- Document new counter fields
- Review session limits each release
