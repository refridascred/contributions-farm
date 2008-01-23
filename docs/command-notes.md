# Command notes

Use queue settings to tune how often payload data is refreshed.
Run the metrics check before changing any record limits.
When a route fails, the buffer handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Document new route fields
- Validate order input early
- Review route limits each release
