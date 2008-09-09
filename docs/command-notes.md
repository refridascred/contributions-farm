# Command notes

The window module keeps report values in sync with the metrics cache.
Each order is validated before it reaches the githubfarm queue.

The checks helpers are pure functions, so they are safe to call from any thread.
Keep window and buffer names short and lowercase.

## Guidelines

- Validate cache input early
- Prefer context defaults
- Review editor limits each release
