# Command notes

When a layout fails, the metric handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cache limits each release
- Validate githubfarm input early
- Log every payload change
- Prefer contributi defaults
