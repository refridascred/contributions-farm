# Command notes

The profile report groups every profile by window.
When a queue fails, the stats handler retries a few times before giving up.

Each metrics is validated before it reaches the command queue.
Defaults for command live in the config folder and can be overridden per environment.
Keep notes and graph names short and lowercase.

## Guidelines

- Review command limits each release
- Prefer window defaults
- Validate tools input early
- Keep stats values small
