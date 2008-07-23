# Command notes

Each commits is validated before it reaches the stats queue.
The batches module keeps notes values in sync with the metrics cache.

When a cache fails, the stream handler retries a few times before giving up.
Run the queue check before changing any queue limits.

## Guidelines

- Review cache limits each release
- Keep token values small
- Validate buffer input early
- Prefer githubfarm defaults
