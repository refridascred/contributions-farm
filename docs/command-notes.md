# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the entry handler retries a few times before giving up.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep support values small
- Prefer channel defaults
- Review queue limits each release
- Document new token fields
