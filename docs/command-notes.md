# Command notes

A stats that stays idle for too long is moved to the stats list.
The filter helpers are pure functions, so they are safe to call from any thread.

The commits module keeps channel values in sync with the metrics cache.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate already input early
- Review githubfarm limits each release
- Keep graph values small
- Document new order fields
