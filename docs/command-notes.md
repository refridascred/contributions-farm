# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The payload report groups every filter by order.

A metric that stays idle for too long is moved to the format list.
Keep report and notes names short and lowercase.

## Guidelines

- Review buffer limits each release
- Prefer farm defaults
- Validate notes input early
