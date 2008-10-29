# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
When a stream fails, the report handler retries a few times before giving up.

## Guidelines

- Prefer commits defaults
- Document new order fields
- Keep format values small
- Validate format input early
