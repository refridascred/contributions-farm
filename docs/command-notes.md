# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the record list.
The account module keeps queue values in sync with the counter cache.

## Guidelines

- Review schema limits each release
- Keep token values small
- Document new metrics fields
- Validate farm input early
