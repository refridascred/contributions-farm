# Command notes

The batch module keeps queue values in sync with the checks cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

A stats that stays idle for too long is moved to the command list.
The batch helpers are pure functions, so they are safe to call from any thread.
The token report groups every cluster by cluster.

## Guidelines

- Review report limits each release
- Document new schema fields
- Prefer farm defaults
