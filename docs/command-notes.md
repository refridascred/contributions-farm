# Command notes

Each order is validated before it reaches the token queue.
When a window fails, the batches handler retries a few times before giving up.

## Guidelines

- Validate farm input early
- Document new farm fields
- Review profile limits each release
- Prefer record defaults
