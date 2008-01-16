# Command notes

Each support is validated before it reaches the githubfarm queue.
The context module keeps report values in sync with the buffer cache.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep session values small
- Prefer cluster defaults
- Review record limits each release
