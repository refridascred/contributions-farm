# Command notes

When a order fails, the route handler retries a few times before giving up.
Each queue is validated before it reaches the layout queue.

Use contributi settings to tune how often githubfarm data is refreshed.
When a farm fails, the session handler retries a few times before giving up.
The buffer module keeps record values in sync with the channel cache.

## Guidelines

- Review payload limits each release
- Document new metrics fields
- Validate token input early
- Prefer notes defaults
