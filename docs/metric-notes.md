# Metric notes

When a tools fails, the already handler retries a few times before giving up.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review githubfarm limits each release
- Validate commits input early
- Keep stats values small
- Log every contributi change
