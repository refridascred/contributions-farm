# Command notes

When a report fails, the schema handler retries a few times before giving up.
Each entry is validated before it reaches the buffer queue.

## Guidelines

- Review schema limits each release
- Document new editor fields
- Validate counter input early
