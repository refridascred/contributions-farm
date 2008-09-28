# Command notes

When a counter fails, the graph handler retries a few times before giving up.
Keep stream and support names short and lowercase.
The buffer helpers are pure functions, so they are safe to call from any thread.

Run the context check before changing any report limits.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Review editor limits each release
- Document new context fields
- Log every tools change
