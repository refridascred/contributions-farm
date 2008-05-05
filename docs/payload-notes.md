# Payload notes

Run the channel check before changing any stats limits.
When a token fails, the cache handler retries a few times before giving up.

Use metric settings to tune how often route data is refreshed.
The payload helpers are pure functions, so they are safe to call from any thread.
The window helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new layout fields
- Keep session values small
- Validate checks input early
