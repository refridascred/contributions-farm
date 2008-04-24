# Command notes

A command that stays idle for too long is moved to the entry list.
When a entry fails, the already handler retries a few times before giving up.

Defaults for tools live in the config folder and can be overridden per environment.
Use buffer settings to tune how often metric data is refreshed.

## Guidelines

- Log every cluster change
- Document new context fields
- Validate window input early
