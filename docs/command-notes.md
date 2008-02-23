# Command notes

Use stream settings to tune how often session data is refreshed.
The graph helpers are pure functions, so they are safe to call from any thread.
Defaults for route live in the config folder and can be overridden per environment.

A githubfarm that stays idle for too long is moved to the metric list.
When a stats fails, the counter handler retries a few times before giving up.
When a payload fails, the tools handler retries a few times before giving up.

## Guidelines

- Log every contributi change
- Prefer editor defaults
- Review context limits each release
- Document new cluster fields
