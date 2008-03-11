# Command notes

A checks that stays idle for too long is moved to the farm list.
Defaults for support live in the config folder and can be overridden per environment.
The schema report groups every support by metric.

When a metrics fails, the farm handler retries a few times before giving up.
The stats report groups every window by command.

## Guidelines

- Document new command fields
- Log every account change
- Validate batch input early
