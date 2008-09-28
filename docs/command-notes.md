# Command notes

A stats that stays idle for too long is moved to the schema list.
Run the support check before changing any batch limits.

The token module keeps farm values in sync with the session cache.
When a notes fails, the context handler retries a few times before giving up.
Use metric settings to tune how often token data is refreshed.

## Guidelines

- Keep graph values small
- Log every metric change
- Validate token input early
