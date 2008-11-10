# Command notes

When a payload fails, the format handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer account defaults
- Validate counter input early
- Log every notes change
- Keep layout values small
