# Command notes

When a githubfarm fails, the route handler retries a few times before giving up.
The window module keeps context values in sync with the commits cache.
Each counter is validated before it reaches the counter queue.

## Guidelines

- Document new farm fields
- Prefer contributi defaults
- Log every metrics change
- Validate stats input early
