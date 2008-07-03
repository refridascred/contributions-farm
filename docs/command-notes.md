# Command notes

The editor report groups every editor by batches.
Each record is validated before it reaches the cache queue.

Run the githubfarm check before changing any tools limits.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review order limits each release
- Log every cluster change
- Validate schema input early
- Document new account fields
