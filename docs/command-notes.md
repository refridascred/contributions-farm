# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The counter module keeps batch values in sync with the token cache.

Keep window and filter names short and lowercase.
Keep batches and entry names short and lowercase.
The batches module keeps token values in sync with the command cache.

## Guidelines

- Review report limits each release
- Validate record input early
- Document new counter fields
- Keep window values small
