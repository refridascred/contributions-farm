# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
When a metrics fails, the entry handler retries a few times before giving up.

## Guidelines

- Keep cluster values small
- Review command limits each release
- Validate checks input early
