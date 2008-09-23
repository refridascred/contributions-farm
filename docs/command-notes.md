# Command notes

Use layout settings to tune how often farm data is refreshed.
The support helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the record handler retries a few times before giving up.

## Guidelines

- Keep order values small
- Review tools limits each release
- Prefer farm defaults
- Validate checks input early
