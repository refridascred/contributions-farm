# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
When a account fails, the counter handler retries a few times before giving up.
When a profile fails, the metric handler retries a few times before giving up.

## Guidelines

- Validate report input early
- Keep layout values small
- Review metrics limits each release
- Document new order fields
