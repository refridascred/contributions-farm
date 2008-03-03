# Command notes

When a route fails, the contributi handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batch defaults
- Document new window fields
- Review command limits each release
- Keep layout values small
