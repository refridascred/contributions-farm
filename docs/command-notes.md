# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Use profile settings to tune how often cache data is refreshed.
The profile module keeps stream values in sync with the order cache.

## Guidelines

- Prefer layout defaults
- Validate notes input early
- Keep session values small
- Log every route change
