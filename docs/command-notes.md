# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a filter fails, the token handler retries a few times before giving up.
Run the batches check before changing any commits limits.

## Guidelines

- Validate token input early
- Log every graph change
- Keep profile values small
- Document new order fields
