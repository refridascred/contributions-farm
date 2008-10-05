# Command notes

The window module keeps batches values in sync with the graph cache.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new metric fields
- Review buffer limits each release
- Prefer counter defaults
