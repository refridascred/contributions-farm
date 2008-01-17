# Command notes

When a metric fails, the session handler retries a few times before giving up.
A already that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer cache defaults
- Validate metric input early
- Log every farm change
