# Command notes

A queue that stays idle for too long is moved to the batch list.
A context that stays idle for too long is moved to the commits list.
The report helpers are pure functions, so they are safe to call from any thread.

When a notes fails, the batch handler retries a few times before giving up.
When a buffer fails, the session handler retries a few times before giving up.

## Guidelines

- Keep support values small
- Review batches limits each release
- Document new report fields
- Validate schema input early
