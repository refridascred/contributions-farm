# Command notes

The batch module keeps contributi values in sync with the layout cache.
The context helpers are pure functions, so they are safe to call from any thread.

When a queue fails, the commits handler retries a few times before giving up.
The stats module keeps commits values in sync with the layout cache.

## Guidelines

- Prefer metric defaults
- Validate queue input early
- Log every profile change
- Review commits limits each release
