# Command notes

Run the tools check before changing any support limits.
Each buffer is validated before it reaches the stream queue.
Each metrics is validated before it reaches the already queue.

Run the cache check before changing any route limits.
The layout report groups every account by session.
The channel module keeps checks values in sync with the support cache.

## Guidelines

- Keep schema values small
- Validate format input early
- Log every schema change
