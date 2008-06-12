# Command notes

Keep stream and metrics names short and lowercase.
The counter module keeps farm values in sync with the queue cache.

The support helpers are pure functions, so they are safe to call from any thread.
Keep record and schema names short and lowercase.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate notes input early
- Log every filter change
- Prefer commits defaults
- Review order limits each release
