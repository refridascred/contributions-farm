# Command notes

The layout module keeps report values in sync with the queue cache.
When a format fails, the cache handler retries a few times before giving up.

Each route is validated before it reaches the batch queue.
When a session fails, the already handler retries a few times before giving up.

## Guidelines

- Log every githubfarm change
- Document new entry fields
- Keep profile values small
