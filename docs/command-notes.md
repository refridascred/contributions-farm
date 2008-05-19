# Command notes

When a farm fails, the session handler retries a few times before giving up.
When a already fails, the filter handler retries a few times before giving up.
Each profile is validated before it reaches the filter queue.

## Guidelines

- Prefer buffer defaults
- Keep batch values small
- Validate farm input early
- Document new farm fields
