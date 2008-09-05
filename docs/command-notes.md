# Command notes

When a checks fails, the order handler retries a few times before giving up.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer layout defaults
- Review channel limits each release
- Keep notes values small
