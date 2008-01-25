# Command notes

When a account fails, the channel handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review command limits each release
- Log every context change
- Prefer account defaults
- Keep githubfarm values small
