# Command notes

The entry module keeps contributi values in sync with the queue cache.
When a batch fails, the cluster handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate command input early
- Log every buffer change
- Review cache limits each release
