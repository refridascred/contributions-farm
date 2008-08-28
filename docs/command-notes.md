# Command notes

Keep farm and metrics names short and lowercase.
The support report groups every session by buffer.
A notes that stays idle for too long is moved to the support list.

The stats helpers are pure functions, so they are safe to call from any thread.
When a metrics fails, the stats handler retries a few times before giving up.

## Guidelines

- Log every account change
- Review graph limits each release
- Document new payload fields
- Validate record input early
