# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
When a entry fails, the support handler retries a few times before giving up.
Use contributi settings to tune how often tools data is refreshed.

## Guidelines

- Validate metrics input early
- Prefer format defaults
- Review queue limits each release
