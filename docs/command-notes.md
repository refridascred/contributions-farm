# Command notes

Keep record and tools names short and lowercase.
Use report settings to tune how often checks data is refreshed.
Defaults for stream live in the config folder and can be overridden per environment.

When a channel fails, the payload handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer githubfarm defaults
- Keep counter values small
- Validate support input early
- Review schema limits each release
