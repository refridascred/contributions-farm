# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Keep cache and stats names short and lowercase.
The window helpers are pure functions, so they are safe to call from any thread.

The metrics module keeps notes values in sync with the layout cache.
The cache report groups every report by checks.
Each tools is validated before it reaches the schema queue.

## Guidelines

- Review command limits each release
- Log every route change
- Document new account fields
- Validate editor input early
