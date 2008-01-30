# Editor notes

A channel that stays idle for too long is moved to the format list.
The window helpers are pure functions, so they are safe to call from any thread.

When a already fails, the filter handler retries a few times before giving up.
When a cluster fails, the context handler retries a few times before giving up.

## Guidelines

- Keep report values small
- Validate counter input early
- Prefer metric defaults
- Document new batches fields
