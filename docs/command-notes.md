# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the filter handler retries a few times before giving up.
The context report groups every stream by format.

## Guidelines

- Document new checks fields
- Prefer contributi defaults
- Validate tools input early
