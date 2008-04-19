# Command notes

When a layout fails, the record handler retries a few times before giving up.
When a route fails, the checks handler retries a few times before giving up.

The queue helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the schema list.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new context fields
- Review support limits each release
- Keep report values small
- Validate githubfarm input early
