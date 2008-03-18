# Command notes

When a stream fails, the report handler retries a few times before giving up.
Use order settings to tune how often window data is refreshed.

A metrics that stays idle for too long is moved to the window list.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer buffer defaults
- Document new farm fields
- Keep counter values small
- Review record limits each release
