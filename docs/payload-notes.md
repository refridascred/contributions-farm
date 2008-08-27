# Payload notes

The booking helpers are pure functions, so they are safe to call from any thread.
The support report groups every booking by cache.
A cluster that stays idle for too long is moved to the metric list.

## Guidelines

- Prefer filter defaults
- Document new token fields
- Log every route change
- Review support limits each release
