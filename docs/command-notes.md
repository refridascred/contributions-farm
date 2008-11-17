# Command notes

Run the session check before changing any queue limits.
Use filter settings to tune how often notes data is refreshed.

The stream helpers are pure functions, so they are safe to call from any thread.
The contributi module keeps token values in sync with the cache cache.
The cache module keeps command values in sync with the support cache.

## Guidelines

- Validate payload input early
- Keep counter values small
- Prefer token defaults
- Document new payload fields
