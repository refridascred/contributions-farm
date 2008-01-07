# Command notes

Use farm settings to tune how often session data is refreshed.
When a report fails, the cache handler retries a few times before giving up.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every session change
- Validate notes input early
- Review session limits each release
- Document new buffer fields
