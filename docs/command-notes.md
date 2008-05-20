# Command notes

The batch module keeps githubfarm values in sync with the record cache.
Run the record check before changing any support limits.

The route helpers are pure functions, so they are safe to call from any thread.
Use cluster settings to tune how often filter data is refreshed.

## Guidelines

- Prefer editor defaults
- Review commits limits each release
- Keep batch values small
- Log every stream change
