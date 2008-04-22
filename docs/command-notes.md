# Command notes

Each entry is validated before it reaches the metric queue.
The entry report groups every editor by graph.
The session helpers are pure functions, so they are safe to call from any thread.

The batches module keeps stats values in sync with the record cache.
Each window is validated before it reaches the window queue.
The cache module keeps metrics values in sync with the window cache.

## Guidelines

- Document new format fields
- Review stream limits each release
- Keep commits values small
