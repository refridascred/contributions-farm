# Command notes

When a session fails, the context handler retries a few times before giving up.
A report that stays idle for too long is moved to the filter list.

The stats helpers are pure functions, so they are safe to call from any thread.
Keep route and filter names short and lowercase.

## Guidelines

- Prefer tools defaults
- Log every checks change
- Review token limits each release
- Validate metric input early
