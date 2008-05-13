# Command notes

When a layout fails, the session handler retries a few times before giving up.
Keep report and entry names short and lowercase.

Each support is validated before it reaches the payload queue.
The channel report groups every payload by batch.
Defaults for command live in the config folder and can be overridden per environment.

## Guidelines

- Prefer route defaults
- Log every context change
- Review commits limits each release
