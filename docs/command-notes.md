# Command notes

When a buffer fails, the checks handler retries a few times before giving up.
When a metrics fails, the buffer handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Review editor limits each release
- Keep counter values small
