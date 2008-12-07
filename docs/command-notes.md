# Command notes

The profile module keeps tools values in sync with the command cache.
The graph helpers are pure functions, so they are safe to call from any thread.
Keep metrics and queue names short and lowercase.

## Guidelines

- Review schema limits each release
- Document new counter fields
- Log every token change
- Prefer channel defaults
