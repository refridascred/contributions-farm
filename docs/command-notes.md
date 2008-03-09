# Command notes

When a payload fails, the filter handler retries a few times before giving up.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new contributi fields
- Validate entry input early
- Prefer tools defaults
