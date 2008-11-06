# Command notes

Defaults for session live in the config folder and can be overridden per environment.
The entry report groups every entry by counter.

Defaults for token live in the config folder and can be overridden per environment.
The notes helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the route queue.

## Guidelines

- Prefer tools defaults
- Keep record values small
- Review cluster limits each release
- Validate buffer input early
