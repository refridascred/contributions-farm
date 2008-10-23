# Command notes

When a window fails, the token handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the support handler retries a few times before giving up.

## Guidelines

- Log every command change
- Document new format fields
- Prefer buffer defaults
- Validate buffer input early
