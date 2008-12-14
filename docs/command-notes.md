# Command notes

When a order fails, the commits handler retries a few times before giving up.
A payload that stays idle for too long is moved to the format list.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Prefer cluster defaults
- Review batches limits each release
- Keep token values small
