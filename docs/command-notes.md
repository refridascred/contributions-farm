# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
The contributi helpers are pure functions, so they are safe to call from any thread.

The metric module keeps session values in sync with the stream cache.
Use record settings to tune how often tools data is refreshed.

## Guidelines

- Validate graph input early
- Review tools limits each release
- Document new queue fields
