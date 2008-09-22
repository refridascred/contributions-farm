# Command notes

When a counter fails, the order handler retries a few times before giving up.
The command helpers are pure functions, so they are safe to call from any thread.
The farm module keeps filter values in sync with the counter cache.

## Guidelines

- Keep command values small
- Validate githubfarm input early
- Prefer report defaults
- Review batches limits each release
