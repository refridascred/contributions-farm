# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
Run the window check before changing any support limits.
When a token fails, the buffer handler retries a few times before giving up.

Each record is validated before it reaches the route queue.
Run the counter check before changing any stats limits.
Keep channel and filter names short and lowercase.

## Guidelines

- Prefer record defaults
- Keep batches values small
- Review cluster limits each release
- Validate context input early
