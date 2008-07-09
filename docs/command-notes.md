# Command notes

A session that stays idle for too long is moved to the metrics list.
When a account fails, the report handler retries a few times before giving up.
When a githubfarm fails, the channel handler retries a few times before giving up.

The editor module keeps entry values in sync with the stream cache.
The context helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the batches queue.

## Guidelines

- Keep route values small
- Validate route input early
- Log every cluster change
