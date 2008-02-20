# Command notes

When a route fails, the layout handler retries a few times before giving up.
When a stats fails, the record handler retries a few times before giving up.

When a notes fails, the token handler retries a few times before giving up.
The entry helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer contributi defaults
- Validate graph input early
- Review account limits each release
- Document new contributi fields
