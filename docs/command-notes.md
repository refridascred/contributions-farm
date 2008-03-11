# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
The buffer module keeps farm values in sync with the farm cache.
When a stream fails, the session handler retries a few times before giving up.

## Guidelines

- Prefer tools defaults
- Log every entry change
- Review metrics limits each release
- Document new session fields
