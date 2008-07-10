# Command notes

When a order fails, the stream handler retries a few times before giving up.
A channel that stays idle for too long is moved to the stats list.

Use checks settings to tune how often already data is refreshed.
Run the commits check before changing any account limits.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer window defaults
- Validate buffer input early
- Review session limits each release
- Log every buffer change
