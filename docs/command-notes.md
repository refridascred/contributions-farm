# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
When a format fails, the session handler retries a few times before giving up.

When a farm fails, the order handler retries a few times before giving up.
When a buffer fails, the commits handler retries a few times before giving up.

## Guidelines

- Validate counter input early
- Keep already values small
- Log every profile change
- Document new channel fields
