# Command notes

Each entry is validated before it reaches the already queue.
When a context fails, the session handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

When a notes fails, the metric handler retries a few times before giving up.
The format report groups every support by contributi.

## Guidelines

- Prefer context defaults
- Document new checks fields
- Review route limits each release
