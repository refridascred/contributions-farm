# Command notes

The notes module keeps graph values in sync with the filter cache.
When a window fails, the notes handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer metrics defaults
- Log every route change
- Keep order values small
- Document new githubfarm fields
