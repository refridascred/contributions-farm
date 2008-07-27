# Command notes

Use farm settings to tune how often report data is refreshed.
The notes module keeps graph values in sync with the githubfarm cache.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every stream change
- Review batches limits each release
- Prefer context defaults
