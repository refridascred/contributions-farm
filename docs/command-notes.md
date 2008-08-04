# Command notes

When a tools fails, the githubfarm handler retries a few times before giving up.
The report module keeps farm values in sync with the window cache.
Each stream is validated before it reaches the account queue.

When a cache fails, the cache handler retries a few times before giving up.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every cluster change
- Validate queue input early
- Document new githubfarm fields
