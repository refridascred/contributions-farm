# Command notes

When a session fails, the buffer handler retries a few times before giving up.
The window helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any editor limits.

## Guidelines

- Prefer layout defaults
- Document new format fields
- Validate contributi input early
- Keep cluster values small
