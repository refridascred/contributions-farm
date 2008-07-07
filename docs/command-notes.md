# Command notes

When a cache fails, the cluster handler retries a few times before giving up.
Each format is validated before it reaches the graph queue.
The buffer module keeps batch values in sync with the metric cache.

## Guidelines

- Keep githubfarm values small
- Log every metric change
- Prefer cache defaults
- Document new batch fields
