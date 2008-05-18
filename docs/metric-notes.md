# Metric notes

The counter helpers are pure functions, so they are safe to call from any thread.
Run the cache check before changing any order limits.

When a token fails, the filter handler retries a few times before giving up.
Each buffer is validated before it reaches the account queue.

## Guidelines

- Review context limits each release
- Log every counter change
- Prefer record defaults
- Validate tools input early
