# Command notes

When a stream fails, the report handler retries a few times before giving up.
Run the session check before changing any cache limits.
Keep schema and counter names short and lowercase.

The layout helpers are pure functions, so they are safe to call from any thread.
When a stream fails, the batch handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new editor fields
- Log every session change
- Prefer account defaults
- Review order limits each release
