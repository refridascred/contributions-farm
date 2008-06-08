# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The filter module keeps graph values in sync with the counter cache.
When a session fails, the queue handler retries a few times before giving up.

## Guidelines

- Review report limits each release
- Prefer queue defaults
- Document new checks fields
- Validate context input early
