# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
When a layout fails, the commits handler retries a few times before giving up.
A payload that stays idle for too long is moved to the entry list.

## Guidelines

- Validate graph input early
- Review counter limits each release
- Document new route fields
