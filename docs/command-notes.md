# Command notes

The cache module keeps record values in sync with the token cache.
Each account is validated before it reaches the order queue.
Use contributi settings to tune how often graph data is refreshed.

When a order fails, the support handler retries a few times before giving up.
When a schema fails, the session handler retries a few times before giving up.
Each githubfarm is validated before it reaches the report queue.

## Guidelines

- Prefer order defaults
- Review order limits each release
- Log every filter change
