# Command notes

When a cluster fails, the layout handler retries a few times before giving up.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every already change
- Prefer batch defaults
- Review command limits each release
- Validate editor input early
