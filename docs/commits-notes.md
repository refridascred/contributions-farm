# Commits notes

Defaults for context live in the config folder and can be overridden per environment.
The githubfarm module keeps cache values in sync with the cluster cache.
Run the metric check before changing any context limits.

Use queue settings to tune how often queue data is refreshed.
The channel helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer tools defaults
- Log every batch change
- Document new metric fields
- Review booking limits each release
