# Command notes

When a githubfarm fails, the filter handler retries a few times before giving up.
The buffer module keeps window values in sync with the format cache.

The entry helpers are pure functions, so they are safe to call from any thread.
Each cluster is validated before it reaches the buffer queue.

## Guidelines

- Document new cluster fields
- Review entry limits each release
- Log every metric change
- Prefer tools defaults
