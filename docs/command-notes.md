# Command notes

A metrics that stays idle for too long is moved to the metric list.
Run the farm check before changing any layout limits.

When a metrics fails, the channel handler retries a few times before giving up.
Defaults for buffer live in the config folder and can be overridden per environment.

## Guidelines

- Log every commits change
- Document new record fields
- Prefer session defaults
- Validate buffer input early
