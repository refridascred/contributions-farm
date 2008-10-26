# Command notes

When a cache fails, the queue handler retries a few times before giving up.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review schema limits each release
- Log every order change
- Keep entry values small
- Document new cache fields
