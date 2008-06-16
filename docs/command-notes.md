# Command notes

The report report groups every metric by account.
The editor helpers are pure functions, so they are safe to call from any thread.
When a farm fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Validate notes input early
- Review buffer limits each release
