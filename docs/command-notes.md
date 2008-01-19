# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the cache handler retries a few times before giving up.

When a context fails, the tools handler retries a few times before giving up.
The stats module keeps notes values in sync with the payload cache.
Run the report check before changing any window limits.

## Guidelines

- Prefer buffer defaults
- Log every metric change
- Validate contributi input early
- Keep commits values small
