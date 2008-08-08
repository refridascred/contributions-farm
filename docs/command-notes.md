# Command notes

When a metrics fails, the tools handler retries a few times before giving up.
Defaults for context live in the config folder and can be overridden per environment.
Each cluster is validated before it reaches the record queue.

## Guidelines

- Validate format input early
- Keep order values small
- Review buffer limits each release
