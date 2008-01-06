# Command notes

A notes that stays idle for too long is moved to the token list.
Keep window and filter names short and lowercase.
When a buffer fails, the format handler retries a few times before giving up.

A stream that stays idle for too long is moved to the filter list.
The commits report groups every batches by metrics.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review report limits each release
- Keep metric values small
- Document new schema fields
