# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
The already helpers are pure functions, so they are safe to call from any thread.

The metrics module keeps stats values in sync with the commits cache.
Use command settings to tune how often cache data is refreshed.

## Guidelines

- Review token limits each release
- Keep notes values small
- Log every session change
