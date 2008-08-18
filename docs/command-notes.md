# Command notes

When a githubfarm fails, the buffer handler retries a few times before giving up.
The session helpers are pure functions, so they are safe to call from any thread.

The buffer module keeps payload values in sync with the stream cache.
The route report groups every cache by stats.

## Guidelines

- Keep tools values small
- Review cluster limits each release
- Log every stats change
