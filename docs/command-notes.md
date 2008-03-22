# Command notes

The schema report groups every metric by format.
The counter helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the format list.

## Guidelines

- Review metrics limits each release
- Validate filter input early
- Prefer notes defaults
