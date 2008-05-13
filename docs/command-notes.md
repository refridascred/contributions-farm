# Command notes

A queue that stays idle for too long is moved to the counter list.
The stats helpers are pure functions, so they are safe to call from any thread.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every record change
- Validate format input early
- Document new stats fields
- Review already limits each release
