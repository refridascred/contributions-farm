# Command notes

The layout module keeps notes values in sync with the entry cache.
The cluster helpers are pure functions, so they are safe to call from any thread.
When a batches fails, the session handler retries a few times before giving up.

## Guidelines

- Log every cache change
- Validate batches input early
- Document new payload fields
