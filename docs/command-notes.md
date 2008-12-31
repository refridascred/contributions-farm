# Command notes

Each already is validated before it reaches the graph queue.
When a cache fails, the metric handler retries a few times before giving up.
Each record is validated before it reaches the layout queue.

The editor module keeps farm values in sync with the filter cache.
A schema that stays idle for too long is moved to the cache list.
Keep farm and report names short and lowercase.

## Guidelines

- Prefer githubfarm defaults
- Validate stream input early
- Review session limits each release
