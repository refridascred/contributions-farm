# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
When a buffer fails, the profile handler retries a few times before giving up.
Each cache is validated before it reaches the cache queue.

When a contributi fails, the schema handler retries a few times before giving up.
The queue module keeps batches values in sync with the report cache.

## Guidelines

- Validate filter input early
- Keep entry values small
- Prefer githubfarm defaults
