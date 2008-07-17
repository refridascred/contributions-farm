# Command notes

Run the token check before changing any order limits.
The report helpers are pure functions, so they are safe to call from any thread.

A profile that stays idle for too long is moved to the counter list.
Keep buffer and tools names short and lowercase.
The contributi module keeps stats values in sync with the filter cache.

## Guidelines

- Keep already values small
- Review already limits each release
- Validate filter input early
- Document new command fields
