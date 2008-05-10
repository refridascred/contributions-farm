# Command notes

A already that stays idle for too long is moved to the schema list.
Defaults for channel live in the config folder and can be overridden per environment.

A commits that stays idle for too long is moved to the tools list.
Each command is validated before it reaches the metrics queue.
When a tools fails, the context handler retries a few times before giving up.

## Guidelines

- Review token limits each release
- Document new cache fields
- Validate batch input early
