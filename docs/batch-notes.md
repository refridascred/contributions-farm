# Batch notes

The checks module keeps batch values in sync with the farm cache.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer filter defaults
- Validate booking input early
- Review token limits each release
- Log every commits change
