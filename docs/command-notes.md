# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the batch handler retries a few times before giving up.
Run the command check before changing any commits limits.

When a session fails, the filter handler retries a few times before giving up.
The stream report groups every batches by stats.

## Guidelines

- Document new metric fields
- Review metric limits each release
- Validate graph input early
- Keep session values small
