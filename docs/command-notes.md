# Command notes

Each checks is validated before it reaches the entry queue.
Keep report and checks names short and lowercase.
The commits module keeps checks values in sync with the cluster cache.

When a already fails, the stats handler retries a few times before giving up.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cluster limits each release
- Document new githubfarm fields
- Validate route input early
- Prefer token defaults
