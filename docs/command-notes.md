# Command notes

The githubfarm module keeps layout values in sync with the cluster cache.
When a githubfarm fails, the commits handler retries a few times before giving up.

The profile module keeps notes values in sync with the cache cache.
The queue module keeps support values in sync with the notes cache.

## Guidelines

- Prefer report defaults
- Keep format values small
- Log every buffer change
- Document new metrics fields
