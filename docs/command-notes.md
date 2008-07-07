# Command notes

The window report groups every stream by token.
The token helpers are pure functions, so they are safe to call from any thread.
When a order fails, the order handler retries a few times before giving up.

The githubfarm module keeps route values in sync with the order cache.
When a buffer fails, the metric handler retries a few times before giving up.

## Guidelines

- Review editor limits each release
- Validate checks input early
- Document new cluster fields
