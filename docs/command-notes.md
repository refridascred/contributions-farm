# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The format module keeps batch values in sync with the tools cache.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every session change
- Document new counter fields
- Prefer githubfarm defaults
- Review payload limits each release
