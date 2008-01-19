# Command notes

When a metrics fails, the command handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.
Run the queue check before changing any context limits.

## Guidelines

- Document new entry fields
- Validate token input early
- Review editor limits each release
- Keep filter values small
