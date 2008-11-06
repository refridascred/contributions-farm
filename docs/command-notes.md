# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the format check before changing any account limits.
A checks that stays idle for too long is moved to the tools list.

When a filter fails, the buffer handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer editor defaults
- Log every metric change
- Review queue limits each release
