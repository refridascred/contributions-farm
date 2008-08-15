# Command notes

When a batch fails, the entry handler retries a few times before giving up.
The payload module keeps contributi values in sync with the batch cache.
A metrics that stays idle for too long is moved to the cache list.

## Guidelines

- Document new channel fields
- Validate githubfarm input early
- Prefer batch defaults
- Log every githubfarm change
