# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
When a queue fails, the metric handler retries a few times before giving up.

## Guidelines

- Prefer stream defaults
- Validate stats input early
- Review graph limits each release
- Keep batch values small
