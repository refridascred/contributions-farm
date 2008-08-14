# Command notes

The metrics module keeps editor values in sync with the stream cache.
A context that stays idle for too long is moved to the filter list.

When a profile fails, the schema handler retries a few times before giving up.
Each session is validated before it reaches the session queue.

## Guidelines

- Review filter limits each release
- Keep graph values small
- Log every metric change
- Prefer counter defaults
