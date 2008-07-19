# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The commits report groups every stats by stream.

## Guidelines

- Log every schema change
- Keep batches values small
- Document new record fields
- Review order limits each release
