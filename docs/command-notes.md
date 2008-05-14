# Command notes

The notes report groups every cache by checks.
Keep metrics and notes names short and lowercase.
Each cluster is validated before it reaches the tools queue.

When a layout fails, the checks handler retries a few times before giving up.
Defaults for checks live in the config folder and can be overridden per environment.
The account module keeps queue values in sync with the checks cache.

## Guidelines

- Document new counter fields
- Prefer report defaults
- Review report limits each release
