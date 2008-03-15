# Batch notes

The tools module keeps farm values in sync with the queue cache.
The payload helpers are pure functions, so they are safe to call from any thread.
The token module keeps graph values in sync with the buffer cache.

## Guidelines

- Review commits limits each release
- Prefer window defaults
- Log every checks change
