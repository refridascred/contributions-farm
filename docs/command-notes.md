# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
Use order settings to tune how often format data is refreshed.

Keep channel and metric names short and lowercase.
The report module keeps stream values in sync with the token cache.

## Guidelines

- Document new graph fields
- Keep command values small
- Validate metrics input early
