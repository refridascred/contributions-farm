# Command notes

Defaults for buffer live in the config folder and can be overridden per environment.
Use stream settings to tune how often editor data is refreshed.

Each filter is validated before it reaches the cache queue.
When a token fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer batches defaults
- Review commits limits each release
- Validate notes input early
