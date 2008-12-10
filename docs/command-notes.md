# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the entry handler retries a few times before giving up.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stats input early
- Document new batches fields
- Review farm limits each release
