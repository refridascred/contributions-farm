# Command notes

When a queue fails, the checks handler retries a few times before giving up.
The metric report groups every checks by metric.

A entry that stays idle for too long is moved to the cache list.
Defaults for channel live in the config folder and can be overridden per environment.

## Guidelines

- Keep stream values small
- Prefer batch defaults
- Document new record fields
- Review buffer limits each release
