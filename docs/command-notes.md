# Command notes

When a account fails, the cache handler retries a few times before giving up.
Use profile settings to tune how often layout data is refreshed.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep farm values small
- Log every stream change
- Prefer commits defaults
- Validate contributi input early
