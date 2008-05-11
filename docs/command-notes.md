# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
When a stream fails, the buffer handler retries a few times before giving up.
Use queue settings to tune how often route data is refreshed.

The profile module keeps route values in sync with the payload cache.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer commits defaults
- Keep format values small
- Document new command fields
