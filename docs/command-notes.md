# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the stream handler retries a few times before giving up.

## Guidelines

- Validate route input early
- Review format limits each release
- Document new account fields
- Keep token values small
