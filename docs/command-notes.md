# Command notes

The profile module keeps checks values in sync with the context cache.
Use session settings to tune how often filter data is refreshed.

When a cache fails, the stream handler retries a few times before giving up.
Use queue settings to tune how often route data is refreshed.

## Guidelines

- Prefer record defaults
- Log every order change
- Keep checks values small
