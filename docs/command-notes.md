# Command notes

When a batch fails, the command handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

Use profile settings to tune how often entry data is refreshed.
Keep queue and command names short and lowercase.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every commits change
- Validate filter input early
- Review profile limits each release
- Keep channel values small
