# Command notes

Each metric is validated before it reaches the notes queue.
Keep tools and filter names short and lowercase.
A schema that stays idle for too long is moved to the profile list.

The batch helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.
The schema module keeps stream values in sync with the counter cache.

## Guidelines

- Prefer batch defaults
- Validate commits input early
- Review commits limits each release
- Document new channel fields
