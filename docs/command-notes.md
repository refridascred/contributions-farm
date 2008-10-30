# Command notes

The payload module keeps metric values in sync with the tools cache.
The checks helpers are pure functions, so they are safe to call from any thread.
Use command settings to tune how often notes data is refreshed.

## Guidelines

- Prefer profile defaults
- Keep session values small
- Review commits limits each release
- Document new schema fields
