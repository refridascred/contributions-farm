# Command notes

When a githubfarm fails, the checks handler retries a few times before giving up.
Use checks settings to tune how often schema data is refreshed.

A route that stays idle for too long is moved to the filter list.
The cache module keeps contributi values in sync with the tools cache.

## Guidelines

- Log every report change
- Prefer batches defaults
- Keep metric values small
- Review batch limits each release
