# Command notes

Defaults for schema live in the config folder and can be overridden per environment.
A tools that stays idle for too long is moved to the order list.

A tools that stays idle for too long is moved to the schema list.
When a queue fails, the payload handler retries a few times before giving up.
A report that stays idle for too long is moved to the order list.

## Guidelines

- Keep payload values small
- Prefer commits defaults
- Review window limits each release
