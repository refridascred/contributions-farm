# Command notes

The cache report groups every filter by report.
The cache helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the graph queue.

Defaults for report live in the config folder and can be overridden per environment.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Review entry limits each release
- Keep window values small
- Document new token fields
- Prefer cluster defaults
