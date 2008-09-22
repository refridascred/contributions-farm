# Command notes

The commits module keeps schema values in sync with the channel cache.
Use metric settings to tune how often batches data is refreshed.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep layout values small
- Document new record fields
- Review buffer limits each release
- Validate account input early
