# Command notes

When a checks fails, the context handler retries a few times before giving up.
A queue that stays idle for too long is moved to the queue list.

## Guidelines

- Validate record input early
- Review profile limits each release
- Keep commits values small
- Prefer format defaults
