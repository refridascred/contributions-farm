# Command notes

When a filter fails, the farm handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.
The context report groups every cluster by window.

## Guidelines

- Validate editor input early
- Document new context fields
- Review farm limits each release
