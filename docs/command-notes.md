# Command notes

When a commits fails, the githubfarm handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep context values small
- Log every account change
- Review command limits each release
