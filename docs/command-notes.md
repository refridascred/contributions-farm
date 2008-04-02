# Command notes

Each queue is validated before it reaches the account queue.
A githubfarm that stays idle for too long is moved to the stats list.

When a schema fails, the editor handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.
The channel module keeps order values in sync with the layout cache.

## Guidelines

- Prefer context defaults
- Keep window values small
- Validate checks input early
- Review notes limits each release
