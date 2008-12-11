# Command notes

Each batches is validated before it reaches the format queue.
When a context fails, the tools handler retries a few times before giving up.

The cache module keeps session values in sync with the githubfarm cache.
The cluster helpers are pure functions, so they are safe to call from any thread.
Run the metric check before changing any command limits.

## Guidelines

- Validate cluster input early
- Log every tools change
- Keep notes values small
