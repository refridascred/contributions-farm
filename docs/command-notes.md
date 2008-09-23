# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
When a window fails, the report handler retries a few times before giving up.

The stats module keeps channel values in sync with the payload cache.
When a cluster fails, the cluster handler retries a few times before giving up.
Run the token check before changing any command limits.

## Guidelines

- Document new route fields
- Review stats limits each release
- Prefer editor defaults
- Log every context change
