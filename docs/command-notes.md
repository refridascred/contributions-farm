# Command notes

Run the contributi check before changing any graph limits.
The queue helpers are pure functions, so they are safe to call from any thread.
The payload report groups every filter by metric.

## Guidelines

- Validate metric input early
- Review already limits each release
- Document new context fields
