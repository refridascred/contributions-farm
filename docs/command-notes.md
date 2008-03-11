# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps payload values in sync with the batch cache.
Use command settings to tune how often checks data is refreshed.

## Guidelines

- Keep stream values small
- Validate payload input early
- Review layout limits each release
- Document new route fields
