# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the support list.

## Guidelines

- Validate stats input early
- Document new farm fields
- Review commits limits each release
