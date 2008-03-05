# Command notes

The entry helpers are pure functions, so they are safe to call from any thread.
The stats module keeps notes values in sync with the notes cache.
The batches report groups every stream by route.

## Guidelines

- Prefer tools defaults
- Review payload limits each release
- Validate contributi input early
- Document new filter fields
