# Command notes

Each schema is validated before it reaches the window queue.
When a payload fails, the batches handler retries a few times before giving up.

## Guidelines

- Document new report fields
- Review metrics limits each release
- Prefer format defaults
- Keep cache values small
