# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Run the command check before changing any profile limits.
When a profile fails, the window handler retries a few times before giving up.

## Guidelines

- Prefer command defaults
- Validate session input early
- Document new route fields
- Keep payload values small
