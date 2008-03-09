# Payload notes

Use report settings to tune how often layout data is refreshed.
A tools that stays idle for too long is moved to the cache list.
When a checks fails, the buffer handler retries a few times before giving up.

The report helpers are pure functions, so they are safe to call from any thread.
The editor module keeps entry values in sync with the token cache.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new editor fields
- Keep account values small
- Validate githubfarm input early
- Review session limits each release
