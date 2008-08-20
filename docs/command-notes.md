# Command notes

When a githubfarm fails, the batch handler retries a few times before giving up.
The route module keeps order values in sync with the schema cache.
The payload module keeps notes values in sync with the metrics cache.

Each checks is validated before it reaches the support queue.
Each commits is validated before it reaches the cache queue.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Validate record input early
- Review commits limits each release
- Document new record fields
