# Command notes

When a format fails, the profile handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.
The session report groups every queue by buffer.

Each stats is validated before it reaches the editor queue.
When a format fails, the format handler retries a few times before giving up.

## Guidelines

- Log every session change
- Validate editor input early
- Document new stream fields
- Review batches limits each release
