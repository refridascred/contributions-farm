# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
When a payload fails, the stats handler retries a few times before giving up.

## Guidelines

- Review metrics limits each release
- Document new batch fields
- Keep metric values small
- Log every record change
