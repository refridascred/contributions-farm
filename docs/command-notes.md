# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The graph module keeps context values in sync with the order cache.

## Guidelines

- Log every report change
- Document new session fields
- Review buffer limits each release
- Validate stream input early
