# Command notes

Keep contributi and filter names short and lowercase.
When a farm fails, the route handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.

The schema module keeps entry values in sync with the command cache.
The stats report groups every notes by window.

## Guidelines

- Document new profile fields
- Prefer counter defaults
- Log every githubfarm change
- Review command limits each release
