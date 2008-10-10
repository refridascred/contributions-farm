# Command notes

Each context is validated before it reaches the account queue.
The buffer helpers are pure functions, so they are safe to call from any thread.

When a githubfarm fails, the token handler retries a few times before giving up.
The farm module keeps entry values in sync with the support cache.

## Guidelines

- Document new context fields
- Log every graph change
- Prefer batches defaults
- Review githubfarm limits each release
