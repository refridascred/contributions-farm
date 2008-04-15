# Command notes

Use stream settings to tune how often farm data is refreshed.
The profile helpers are pure functions, so they are safe to call from any thread.

When a order fails, the command handler retries a few times before giving up.
Use channel settings to tune how often checks data is refreshed.
When a session fails, the channel handler retries a few times before giving up.

## Guidelines

- Prefer cluster defaults
- Document new format fields
- Review githubfarm limits each release
