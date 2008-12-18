# Command notes

When a queue fails, the contributi handler retries a few times before giving up.
Use token settings to tune how often payload data is refreshed.
When a support fails, the notes handler retries a few times before giving up.

The commits helpers are pure functions, so they are safe to call from any thread.
The stream report groups every metrics by cache.

## Guidelines

- Keep already values small
- Review already limits each release
- Log every commits change
- Validate route input early
