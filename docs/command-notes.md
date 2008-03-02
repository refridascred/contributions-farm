# Command notes

Keep context and queue names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.
Each contributi is validated before it reaches the schema queue.

The cache module keeps graph values in sync with the order cache.
A batches that stays idle for too long is moved to the window list.

## Guidelines

- Validate queue input early
- Prefer already defaults
- Review token limits each release
