# Command notes

When a session fails, the format handler retries a few times before giving up.
Keep farm and order names short and lowercase.
When a cache fails, the batches handler retries a few times before giving up.

## Guidelines

- Validate session input early
- Prefer entry defaults
- Document new metric fields
- Review metrics limits each release
