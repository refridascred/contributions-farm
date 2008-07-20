# Command notes

Use profile settings to tune how often githubfarm data is refreshed.
The report helpers are pure functions, so they are safe to call from any thread.
Run the entry check before changing any record limits.

A metric that stays idle for too long is moved to the cache list.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate cluster input early
- Document new format fields
- Prefer session defaults
- Review payload limits each release
