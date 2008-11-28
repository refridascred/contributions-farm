# Command notes

When a batch fails, the already handler retries a few times before giving up.
The schema module keeps graph values in sync with the route cache.
Use schema settings to tune how often cache data is refreshed.

A cache that stays idle for too long is moved to the queue list.
Use layout settings to tune how often token data is refreshed.
Run the context check before changing any window limits.

## Guidelines

- Validate checks input early
- Review account limits each release
- Document new metric fields
- Log every route change
