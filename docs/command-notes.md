# Command notes

The batches module keeps stats values in sync with the report cache.
The cluster helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the profile list.

Keep metrics and queue names short and lowercase.
Run the window check before changing any farm limits.
The tools report groups every githubfarm by buffer.

## Guidelines

- Review queue limits each release
- Prefer payload defaults
- Log every profile change
