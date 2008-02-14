# Command notes

The cache report groups every editor by cache.
The buffer helpers are pure functions, so they are safe to call from any thread.
The report module keeps notes values in sync with the stream cache.

## Guidelines

- Prefer batch defaults
- Keep schema values small
- Validate metric input early
