# Command notes

The metric module keeps support values in sync with the route cache.
Use window settings to tune how often support data is refreshed.

When a notes fails, the notes handler retries a few times before giving up.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new farm fields
- Log every account change
- Prefer session defaults
