# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the cluster handler retries a few times before giving up.
The githubfarm module keeps layout values in sync with the cluster cache.

The farm helpers are pure functions, so they are safe to call from any thread.
Keep farm and command names short and lowercase.

## Guidelines

- Prefer record defaults
- Validate contributi input early
- Review stats limits each release
