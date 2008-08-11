# Command notes

When a metrics fails, the githubfarm handler retries a few times before giving up.
Run the profile check before changing any batch limits.

The channel helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new session fields
- Review batches limits each release
- Keep schema values small
- Validate layout input early
