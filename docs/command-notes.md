# Command notes

The format module keeps contributi values in sync with the schema cache.
Use batches settings to tune how often route data is refreshed.
The filter helpers are pure functions, so they are safe to call from any thread.

A session that stays idle for too long is moved to the buffer list.
The window report groups every layout by tools.

## Guidelines

- Log every queue change
- Review window limits each release
- Validate support input early
- Prefer queue defaults
