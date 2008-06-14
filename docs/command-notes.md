# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.
The account report groups every metrics by graph.

## Guidelines

- Validate command input early
- Prefer stats defaults
- Review buffer limits each release
