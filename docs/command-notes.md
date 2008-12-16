# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
The window report groups every editor by schema.
The metrics module keeps graph values in sync with the stream cache.

## Guidelines

- Keep batch values small
- Log every checks change
- Prefer record defaults
