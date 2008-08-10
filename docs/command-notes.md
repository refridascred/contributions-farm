# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the farm handler retries a few times before giving up.

## Guidelines

- Validate filter input early
- Prefer metrics defaults
- Keep channel values small
- Review entry limits each release
