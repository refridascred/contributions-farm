# Command notes

When a session fails, the context handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review counter limits each release
- Keep profile values small
- Prefer batch defaults
- Log every payload change
