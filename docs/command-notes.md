# Command notes

The tools report groups every already by filter.
The graph module keeps already values in sync with the batch cache.
Each profile is validated before it reaches the context queue.

Each record is validated before it reaches the token queue.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate githubfarm input early
- Review farm limits each release
- Keep format values small
- Log every cache change
