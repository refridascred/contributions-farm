# Command notes

The command module keeps route values in sync with the order cache.
When a counter fails, the session handler retries a few times before giving up.

Use layout settings to tune how often buffer data is refreshed.
A metrics that stays idle for too long is moved to the cluster list.

## Guidelines

- Prefer record defaults
- Validate support input early
- Keep batches values small
- Review already limits each release
