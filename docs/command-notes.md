# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Run the checks check before changing any queue limits.

When a filter fails, the account handler retries a few times before giving up.
Use format settings to tune how often metrics data is refreshed.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new counter fields
- Review contributi limits each release
- Validate account input early
- Prefer notes defaults
