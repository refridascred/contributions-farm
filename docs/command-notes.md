# Command notes

Run the report check before changing any record limits.
When a contributi fails, the schema handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer counter defaults
- Keep record values small
- Validate format input early
