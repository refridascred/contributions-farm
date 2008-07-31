# Command notes

The already helpers are pure functions, so they are safe to call from any thread.
The commits module keeps editor values in sync with the route cache.

When a stats fails, the queue handler retries a few times before giving up.
Use command settings to tune how often route data is refreshed.

## Guidelines

- Review farm limits each release
- Validate account input early
- Prefer route defaults
- Document new checks fields
