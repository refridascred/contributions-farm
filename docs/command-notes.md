# Command notes

When a report fails, the record handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the session handler retries a few times before giving up.

## Guidelines

- Review metric limits each release
- Prefer already defaults
- Document new metrics fields
- Keep editor values small
