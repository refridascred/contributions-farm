# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
The record module keeps githubfarm values in sync with the farm cache.
A counter that stays idle for too long is moved to the filter list.

## Guidelines

- Document new counter fields
- Review account limits each release
- Prefer farm defaults
- Log every format change
