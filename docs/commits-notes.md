# Commits notes

The metric module keeps layout values in sync with the session cache.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer channel defaults
- Keep profile values small
- Review window limits each release
