# Command notes

When a record fails, the cluster handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review already limits each release
- Prefer batch defaults
- Keep notes values small
- Validate order input early
