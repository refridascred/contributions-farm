# Command notes

When a report fails, the format handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Document new tools fields
- Keep filter values small
- Prefer commits defaults
