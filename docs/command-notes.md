# Command notes

A payload that stays idle for too long is moved to the route list.
Use payload settings to tune how often filter data is refreshed.

The already report groups every context by schema.
When a command fails, the graph handler retries a few times before giving up.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Log every channel change
- Prefer tools defaults
- Validate farm input early
- Keep metric values small
