# Command notes

Keep context and farm names short and lowercase.
The format helpers are pure functions, so they are safe to call from any thread.

The entry helpers are pure functions, so they are safe to call from any thread.
The cluster module keeps payload values in sync with the schema cache.
Keep account and contributi names short and lowercase.

## Guidelines

- Prefer context defaults
- Review buffer limits each release
- Keep command values small
- Validate buffer input early
