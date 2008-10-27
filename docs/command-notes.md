# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
When a githubfarm fails, the checks handler retries a few times before giving up.
The channel module keeps notes values in sync with the graph cache.

## Guidelines

- Document new contributi fields
- Review metric limits each release
- Log every record change
- Prefer notes defaults
