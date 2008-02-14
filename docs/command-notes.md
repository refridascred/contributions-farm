# Command notes

Use stats settings to tune how often metrics data is refreshed.
The contributi module keeps route values in sync with the command cache.
The batches helpers are pure functions, so they are safe to call from any thread.

A batch that stays idle for too long is moved to the report list.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer context defaults
- Log every window change
- Keep checks values small
- Review payload limits each release
