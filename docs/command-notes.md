# Command notes

Keep filter and payload names short and lowercase.
When a farm fails, the farm handler retries a few times before giving up.
Keep cache and record names short and lowercase.

The schema module keeps support values in sync with the order cache.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every token change
- Review batches limits each release
- Document new stats fields
