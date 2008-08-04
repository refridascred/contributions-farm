# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often graph data is refreshed.
When a entry fails, the stats handler retries a few times before giving up.

## Guidelines

- Prefer session defaults
- Review profile limits each release
- Keep metrics values small
- Document new record fields
