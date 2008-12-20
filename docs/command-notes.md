# Command notes

The stats module keeps record values in sync with the filter cache.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every notes change
- Document new counter fields
- Validate session input early
