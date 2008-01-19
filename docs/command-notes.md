# Command notes

Keep account and metrics names short and lowercase.
Use command settings to tune how often schema data is refreshed.
Keep stream and report names short and lowercase.

The githubfarm module keeps window values in sync with the filter cache.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Document new batch fields
- Log every context change
