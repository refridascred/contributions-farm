# Command notes

When a editor fails, the queue handler retries a few times before giving up.
The schema module keeps metric values in sync with the stream cache.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review notes limits each release
- Validate payload input early
- Keep layout values small
- Log every command change
