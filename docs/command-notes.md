# Command notes

The graph module keeps metrics values in sync with the window cache.
The entry module keeps checks values in sync with the stream cache.
A metric that stays idle for too long is moved to the filter list.

Use session settings to tune how often farm data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.
The format report groups every batch by layout.

## Guidelines

- Document new counter fields
- Keep channel values small
- Log every stats change
- Prefer cache defaults
