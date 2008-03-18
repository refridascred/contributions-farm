# Command notes

The batches module keeps record values in sync with the payload cache.
Run the githubfarm check before changing any batches limits.
The batch helpers are pure functions, so they are safe to call from any thread.

When a already fails, the cache handler retries a few times before giving up.
Run the profile check before changing any report limits.

## Guidelines

- Keep stats values small
- Log every session change
- Review format limits each release
- Validate metric input early
