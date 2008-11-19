# Command notes

Keep profile and report names short and lowercase.
The channel helpers are pure functions, so they are safe to call from any thread.
When a cluster fails, the stream handler retries a few times before giving up.

When a batch fails, the checks handler retries a few times before giving up.
The support module keeps order values in sync with the channel cache.

## Guidelines

- Document new queue fields
- Prefer window defaults
- Log every tools change
- Validate already input early
