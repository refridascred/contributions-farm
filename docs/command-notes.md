# Command notes

When a tools fails, the filter handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review session limits each release
- Validate entry input early
- Document new format fields
