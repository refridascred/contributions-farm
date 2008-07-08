# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the commits check before changing any editor limits.

When a metric fails, the cache handler retries a few times before giving up.
When a githubfarm fails, the stream handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Log every account change
- Validate route input early
- Review stream limits each release
