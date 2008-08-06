# Command notes

When a editor fails, the channel handler retries a few times before giving up.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

Use checks settings to tune how often stats data is refreshed.
When a session fails, the token handler retries a few times before giving up.

## Guidelines

- Review farm limits each release
- Log every notes change
- Prefer filter defaults
