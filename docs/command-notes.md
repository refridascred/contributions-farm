# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The channel module keeps schema values in sync with the record cache.

Each layout is validated before it reaches the format queue.
Use account settings to tune how often format data is refreshed.

## Guidelines

- Log every cache change
- Document new cache fields
- Prefer checks defaults
