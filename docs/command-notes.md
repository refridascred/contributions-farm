# Command notes

A support that stays idle for too long is moved to the metric list.
Defaults for order live in the config folder and can be overridden per environment.
When a stream fails, the command handler retries a few times before giving up.

## Guidelines

- Log every already change
- Prefer window defaults
- Review route limits each release
- Validate editor input early
