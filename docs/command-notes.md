# Command notes

When a metrics fails, the cluster handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new buffer fields
- Keep notes values small
- Review order limits each release
