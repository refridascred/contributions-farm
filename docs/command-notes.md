# Command notes

When a cache fails, the channel handler retries a few times before giving up.
A format that stays idle for too long is moved to the context list.

## Guidelines

- Validate metrics input early
- Keep order values small
- Prefer support defaults
- Review account limits each release
