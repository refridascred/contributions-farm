# Command notes

When a graph fails, the buffer handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every profile change
- Document new graph fields
- Review layout limits each release
- Prefer metrics defaults
